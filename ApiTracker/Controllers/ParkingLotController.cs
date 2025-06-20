using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;
using System.Net.Http;
using ApiTracker;
using Refit;
using WmsApi.Contracts;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Wms.Telegram;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SignalR;
using Cds.Contracts;
using Ucp.Contracts;
using Contracts;
using System.Collections.Generic;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("tracker/[controller]/[action]")]
    public class ParkingLotController : ControllerBase
    {
        public static string _accessToken;
        private IGateApi _gateApi;
        private IGateTokenApi _gateTokenApi;
        private IServiceProvider _serviceProvider { get; set; }
        private WmspcrContext _dataContext;
        private readonly ILogger<ParkingLotController> _logger;
        private readonly IHubContext<ChatHub> _hubContext;
        public ParkingLotController(ILogger<ParkingLotController> logger, IServiceProvider serviceProvider, WmspcrContext dataContext, IGateApi gateApi, IGateTokenApi token, IHubContext<ChatHub> hubContext)
        {
            _dataContext = dataContext;
            _gateApi = gateApi;
            _gateTokenApi = token;
            _serviceProvider = serviceProvider;
            _logger = logger;
            _hubContext = hubContext;
        }

        #region 车辆预进厂数据推送  入口
        /// <summary>
        /// 车辆预进厂数据推送
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CarPreInPush()
        {
            _logger.LogInformation("接收到入口推送数据");
            //获取加密的body内容
            try
            {
                StreamReader stream = new StreamReader(HttpContext.Request.Body);
                string body = await stream.ReadToEndAsync();

                if (string.IsNullOrEmpty(body))
                {
                    _logger.LogInformation($"接收到入口推送数据，body数据为空");
                }

                #region 获取秘钥
                //获取请求头User-Agent
                string userAgent = HttpContext.Request.Headers["User-Agent"];
                string md5Str = userAgent.Substring(userAgent.LastIndexOf("_") + 1);
                //获取数字的数组
                string[] nums = Regex.Split(md5Str, @"[^0-9]+");
                nums = nums.Where(t => !string.IsNullOrEmpty(t)).ToArray();
                //定义秘钥起始位置
                int cipherNum = 0;
                //获取最后一个数字
                string lastNum = nums[nums.Length - 1];
                if (lastNum.Length > 1)
                {
                    lastNum = lastNum.Substring(lastNum.Length - 1);
                }
                _logger.LogInformation($"接收到入口推送数据，获取最后一个数字{lastNum}");
                cipherNum = Convert.ToInt32(lastNum);
                //获取秘钥
                string key = md5Str.Substring(cipherNum, 16);
                #endregion

                //解密得到json数据
                string jsonBody = AesDecrypt(body, key);
                if (string.IsNullOrEmpty(jsonBody))
                {
                    _logger.LogInformation($"接收到入口推送数据，解析失败");
                    return Ok(new { data = "", resCode = "111111", resMsg = "解析失败！" });
                }
                CarPreComeIn preCar = JsonConvert.DeserializeObject<CarPreComeIn>(jsonBody);
                //preCar.carNum = "鲁L90720";
                _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}");

                string bayNo = preCar.sluiceDevChnName.Substring(0, 2);
                var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum);
                if (trTruck != null)
                {
                    trTruck.DispatchState = 3; // 进入库区
                    trTruck.ArriveTime = DateTime.Now;
                }
                string[] bayNoArr = new string[3];
                if (bayNo == "16")
                {
                    bayNoArr = new string[2] { "16", "17" };
                }
                else if (bayNo == "21")
                {
                    bayNoArr = new string[2] { "21", "22" };
                }
                else if (bayNo == "22")
                {
                    bayNoArr = new string[1] { "23" };
                }
                else if (bayNo == "24")
                {
                    bayNoArr = new string[1] { "24" };
                }

                var bayQueueList = _dataContext.Set<TTrTruckBayQueue>().Where(t => t.IsEnable == 1 && bayNoArr.Contains(t.BayCode) && t.DispatchStepState == 2).ToList();
                if (bayQueueList.Count > 0)
                {
                    var truckNos = bayQueueList.Select(t => t.TruckNo);
                    _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName} 当前等待入库车辆：{string.Join(",", truckNos)}");
                    var curQueueInfo = bayQueueList.FirstOrDefault(t => t.TruckNo == preCar.carNum);
                    if (curQueueInfo != null)
                    {
                        curQueueInfo.DispatchStepState = 3;
                        curQueueInfo.UpdateTime = DateTime.Now;
                        curQueueInfo.EntryBayTime = DateTime.Now;
                        _dataContext.Update(curQueueInfo);

                        //将多库房人工更改排队状态的车置为空
                        if (curQueueInfo.IsMoreBay == 1)
                        {
                            var otherBayList = _dataContext.Set<TTrTruckBayQueue>().Where(t => t.BayCode != curQueueInfo.BayCode && t.MainLoadingNo == curQueueInfo.MainLoadingNo && (t.DispatchStepState == 1 || t.DispatchStepState == 2)).ToList();
                            if (otherBayList.Count > 0)
                            {
                                foreach (var otherBay in otherBayList)
                                {
                                    otherBay.DispatchStepState = 0;
                                    otherBay.UpdateTime = DateTime.Now;
                                    otherBay.Remark += ";未按顺序库房排队";
                                    _dataContext.Update(otherBay);
                                }
                            }
                        }

                        await _dataContext.SaveChangesAsync();
                        //var wmbm17 = new TeleWMBM17
                        //{
                        //    Payload = new TruckInOutInfo
                        //    {
                        //        OperationMark = "E",
                        //        MainTruckLoadingNo = curQueueInfo.MainLoadingNo,
                        //        VehicleNo = curQueueInfo.TruckNo,
                        //        BayNo = curQueueInfo.BayCode,
                        //        House = curQueueInfo.HouseNo
                        //    }
                        //};
                        //var mbs = _serviceProvider.GetService<MbsProxy>();
                        //await mbs.Publish(wmbm17);
                        _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}进入库区成功");
                        return Ok(new { data = new { isOpen = "1" }, resCode = "000000", resMsg = "success" });
                        //if (curQueueInfo.BayCode == "16" || curQueueInfo.BayCode == "17")
                        //{
                        //    return Ok(new { data = new { isOpen = "1" }, resCode = "000000", resMsg = "success" });
                        //}
                    }
                }
                else
                {
                    _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}未收到等待入库的车辆");
                }

                #region Old 允许入库规则
                //入口Ids 判定是出入口
                //var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum);
                //var repoLight = _dataContext.Set<TTrTrafficLight>().AsNoTracking();
                //var plcName = "Light.W16.1";
                //if (preCar.sluiceDevChnName.Contains("25"))
                //{
                //    plcName = "Light.W25.1";
                //}
                //var trafficlight = await repoLight.FirstOrDefaultAsync(t => t.PlcName == plcName);

                ////道闸抬杆要求：1、行车允许，2、停车位空闲，3、当前道闸可进入  (&& trTruck.CraneEnabled == 1 注销掉)
                //if (trTruck != null)
                //{
                //    var allowBayCodes = GetVerifyBayCodes(trTruck, preCar.sluiceDevChnId);
                //    if (allowBayCodes != null && allowBayCodes.Count > 0)
                //    {
                //        _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName},装车库房列表{string.Join(",", allowBayCodes)}");
                //        var isAllowEnter = false;
                //        var parkList = _dataContext.Set<TTrParkingPlace>().Where(t => allowBayCodes.Contains(t.BayCode) && t.IsEnable == 1);
                //        //var bayCodes = allowBayCodes;
                //        foreach (var park in parkList)
                //        {
                //            if (string.IsNullOrEmpty(park.CandidateTruck))
                //            {
                //                park.CandidateTruck = preCar.carNum;
                //                isAllowEnter = true;
                //                break;
                //            }
                //            var parkTrucks = park.CandidateTruck.Split(',');
                //            _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}当前车位：{park.ParkingPlaceId},候选车列表{string.Join(",", park.CandidateTruck)}");
                //            if ((allowBayCodes.Contains(park.BayCode) && parkTrucks.Count() < 2) || (!allowBayCodes.Contains(park.BayCode) && parkTrucks.Count() < 1))
                //            {
                //                if (!parkTrucks.Contains(preCar.carNum))
                //                {
                //                    park.CandidateTruck = park.CandidateTruck + "," + preCar.carNum;
                //                }
                //                isAllowEnter = true;
                //                break;
                //            }
                //        }
                //        if (isAllowEnter)
                //        {
                //            checklight:
                //            if (trafficlight.State != 2)
                //            {
                //                _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}当前红绿灯{trafficlight.Name}不允许等待10秒重新验证");
                //                await Task.Delay(10000);
                //                trafficlight = await repoLight.FirstOrDefaultAsync(t => t.PlcName == plcName);
                //                goto checklight;
                //            }
                //            trTruck.DispatchState = 3; // 进入库区
                //            trTruck.ArriveTime = DateTime.Now;
                //            await _dataContext.SaveChangesAsync();
                //            _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}进入库区成功");
                //            await GateControl(new GateControlParas { ChannelId = preCar.sluiceDevChnId, OperateType = 1 });
                //            return Ok(new { data = new { isOpen = "1" }, resCode = "000000", resMsg = "success" });
                //        }
                //    }
                //    else
                //    {
                //        _logger.LogInformation($"推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}允许allowBayCodes为null");
                //    }
                //}
                #endregion
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"接收到入口推送数据，报错异常：{ex.Message}");
            }
            return Ok(new { data = new { isOpen = "3" }, resCode = "000000", resMsg = "success" });
        }

        private List<string> GetVerifyBayCodes(TTrTruck trTruck, string entranceId)
        {
            try
            {
                var loadListIds = _dataContext.Set<TPlTruckLoadList>().Where(t => t.MainTruckLoadingNo == trTruck.MainTruckLoadingNo && t.IsEnable == 1).Select(t => t.Id).ToList();
                var loadBayCodes = new List<string>();
                if (loadListIds.Count() > 0)
                {
                    loadBayCodes = _dataContext.Set<TTrLocationMaterial>().Where(t => loadListIds.Contains(t.TruckLoadListId)).Select(t => t.BayCode).Distinct().ToList();
                    if (loadBayCodes.Count > 0)
                    {
                        _logger.LogInformation($"推送数据的车牌号：{trTruck.TruckNo},实时装载库房：{string.Join(',', loadBayCodes)},trTruck.LoadBayCodeList装载库房：{trTruck.LoadBayCodeList}");
                    }
                }
                if (loadBayCodes.Count > 0)
                {
                    loadBayCodes = loadBayCodes.Distinct().ToList();
                    string entranceP5 = "1000093$14$0$0";
                    string entranceP6 = "1000024$14$0$0,1000039$14$0$0,1000030$14$0$0";
                    string entranceP8 = "1000054$14$0$0,1000083$14$0$0,1000089$14$0$0";
                    if (!string.IsNullOrEmpty(trTruck.FinishBayCodeList))
                    {
                        var finishLoadBayCodes = trTruck.FinishBayCodeList.Split(',').ToList();
                        loadBayCodes = loadBayCodes.Except(finishLoadBayCodes).ToList();
                    }

                    if (entranceP5.Contains(entranceId))
                    {
                        var bayCodes = new List<string>() { "16", "17" };
                        return loadBayCodes.Intersect(bayCodes).ToList();
                    }
                    //else if (entranceP6.Contains(entranceId))
                    //{
                    //    var bayCodes = new List<string>() { "21", "22", "23", "24" };
                    //    return loadBayCodes.Intersect(bayCodes).ToList();
                    //}
                    else if (entranceP8.Contains(entranceId))
                    {
                        var bayCodes = new List<string>() { "25", "26", "27" };
                        return loadBayCodes.Intersect(bayCodes).ToList();
                    }
                }
                //if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                //{
                //    string entranceP5 = "1000093$14$0$0";
                //    string entranceP6 = "1000024$14$0$0,1000039$14$0$0,1000030$14$0$0";
                //    string entranceP8 = "1000054$14$0$0,1000083$14$0$0,1000089$14$0$0";

                //    var loadBusinessNames = trTruck.LoadBussinessNameList.Split(',').ToList();
                //    if (entranceP5.Contains(entranceId) && loadBusinessNames.Contains("P5"))
                //    {
                //        var bayCodes = new List<string>() { "16", "17" };
                //        return bayCodes;
                //    }
                //    else if (entranceP6.Contains(entranceId) && loadBusinessNames.Contains("P6"))
                //    {
                //        var bayCodes = new List<string>() { "21", "22", "23", "24" };
                //        return bayCodes;
                //    }
                //    else if (entranceP8.Contains(entranceId) && loadBusinessNames.Contains("P8"))
                //    {
                //        var bayCodes = new List<string>() { "25", "26", "27" };
                //        return bayCodes;
                //    }
                //}
                return null;


                #region old 
                //if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                //{
                //    string entranceP5 = "1000093$14$0$0";
                //    string entranceP6 = "1000024$14$0$0,1000039$14$0$0,1000030$14$0$0";
                //    string entranceP8 = "1000054$14$0$0,1000083$14$0$0,1000089$14$0$0";
                //    var loadBayCodes = trTruck.LoadBayCodeList.Split(',').ToList();
                //    if (!string.IsNullOrEmpty(trTruck.FinishBayCodeList))
                //    {
                //        var finishLoadBayCodes = trTruck.FinishBayCodeList.Split(',').ToList();
                //        loadBayCodes = loadBayCodes.Except(finishLoadBayCodes).ToList();
                //    }

                //    if (entranceP5.Contains(entranceId))
                //    {
                //        var bayCodes = new List<string>() { "16", "17" };
                //        return loadBayCodes.Intersect(bayCodes).ToList();
                //    }
                //    //else if (entranceP6.Contains(entranceId))
                //    //{
                //    //    var bayCodes = new List<string>() { "21", "22", "23", "24" };
                //    //    return loadBayCodes.Intersect(bayCodes).ToList();
                //    //}
                //    else if (entranceP8.Contains(entranceId))
                //    {
                //        var bayCodes = new List<string>() { "25", "26", "27" };
                //        return loadBayCodes.Intersect(bayCodes).ToList();
                //    }
                //}
                //return null;
                #endregion
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region 车辆预出厂数据推送 车位
        /// <summary>
        /// 车辆预出厂数据推送
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CarPreOutPush()
        {
            _logger.LogInformation("接收CarPreOut车位推送数据");
            //获取加密的body内容
            StreamReader stream = new StreamReader(HttpContext.Request.Body);
            string body = await stream.ReadToEndAsync();

            #region 获取秘钥
            //获取请求头User-Agent
            string userAgent = HttpContext.Request.Headers["User-Agent"];
            string md5Str = userAgent.Substring(userAgent.LastIndexOf("_") + 1);
            //获取数字的数组
            string[] nums = Regex.Split(md5Str, @"[^0-9]+");
            nums = nums.Where(t => !string.IsNullOrEmpty(t)).ToArray();
            //定义秘钥起始位置
            int cipherNum = 0;
            //获取最后一个数字
            string lastNum = nums[nums.Length - 1];
            if (lastNum.Length > 1)
            {
                lastNum = lastNum.Substring(lastNum.Length - 1);
            }
            cipherNum = Convert.ToInt32(lastNum);
            //获取秘钥
            string key = md5Str.Substring(cipherNum, 16);
            #endregion

            //解密得到json数据
            string jsonBody = AesDecrypt(body, key);
            if (string.IsNullOrEmpty(jsonBody))
            {
                return Ok(new { data = "", resCode = "111111", resMsg = "解析失败！" });
            }
            //用预进厂Model解析
            CarPreComeIn preCar = JsonConvert.DeserializeObject<CarPreComeIn>(jsonBody);
            _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName};道闸ID{preCar.sluiceDevChnId}");
            // t.DispatchState == 2是库位等候，理论上不应该抬杆
            var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum && t.DispatchState >= 2);

            if (trTruck != null)
            {
                if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                {
                    var bayCodeList = trTruck.LoadBayCodeList.Split(',');
                    var parkingPlace = _dataContext.Set<TTrParkingPlace>().FirstOrDefault(t => bayCodeList.Contains(t.BayCode) && t.GateId == preCar.sluiceDevChnId);
                    //肯定不应为Null
                    var eqParking = _dataContext.Set<TEqGateParking>().FirstOrDefault(t => t.GateId == preCar.sluiceDevChnId);
                    var tele1341 = new Tele1341();
                    if (eqParking != null)
                    {
                        tele1341.PartnerId = new Ucp.Contracts.Key(eqParking.Code, eqParking.Code, 1);
                    }
                    tele1341.Payload.TruckNo = preCar.carNum;
                    tele1341.Payload.TruckType = 0;
                    //判断是装车或卸车
                    //退货信息，卸车
                    if (!string.IsNullOrEmpty(trTruck.TruckBackNo))
                    {
                        tele1341.Payload.TruckType = 1;
                    }
                    //库间倒运 根据状态判断卸车
                    if (!string.IsNullOrEmpty(trTruck.TransferNo))
                    {
                        var bayTran = _dataContext.Set<TPlBayTransfer>().FirstOrDefault(t => t.No == trTruck.TransferNo);
                        if (bayTran != null)
                        {
                            //状态 2 3 4 代表卸车
                            if (bayTran.ExecState > 1 && bayTran.ExecState < 5)
                            {
                                tele1341.Payload.TruckType = 1;
                            }
                        }
                        else
                        {
                            _logger.LogInformation($"库间倒运计划号{trTruck.TransferNo}/{trTruck.TruckNo}未找到计划");
                        }
                    }

                    //车辆已进入正确停车位  
                    if (parkingPlace != null)
                    {
                        trTruck.DispatchState = 5;
                        tele1341.Payload.TruckState = 0;
                    }
                    else //车辆未进入正确停车位
                    {
                        trTruck.DispatchState = 4;
                        tele1341.Payload.TruckState = 1;
                        tele1341.Payload.Remark = $"驶入错误停车位，请去{trTruck.ParkingNoSuggest}停车位";
                    }
                    _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}进入车位成功");
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(tele1341);

                    var chnIds = new List<string>() { "1000014$14$0$0", "1000068$14$0$0", "1000071$14$0$0" }; //16B 27A 27B
                    if (!string.IsNullOrEmpty(parkingPlace.CandidateTruck))
                    {
                        var candidateTruckList = parkingPlace.CandidateTruck.Split(',').ToList();
                        _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除前候选车列表{string.Join(",", parkingPlace.CandidateTruck)}");
                        var index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        if (index == -1)
                        {
                            candidateTruckList.Add(preCar.carNum);
                            index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        }
                        if (index > 0)
                        {
                            _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除车牌号(不包含)：{preCar.carNum}");
                            candidateTruckList.RemoveRange(0, index);
                        }
                        //if (!chnIds.Contains(preCar.sluiceDevChnId))
                        //{
                        //    if (index >= 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除车牌号(包含)：{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index + 1);
                        //    }

                        //}
                        //else
                        //{
                        //    if (index > 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除车牌号(不包含)：{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index);
                        //    }
                        //}
                        _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除后候选车列表{string.Join(",", parkingPlace.CandidateTruck)}");
                        parkingPlace.CandidateTruck = string.Join(",", candidateTruckList);
                    }
                    await _dataContext.SaveChangesAsync();
                }
            }
            return Ok(new { data = new { isOpen = "2" }, resCode = "000000", resMsg = "success" });
            //return Ok();
        }
        #endregion

        #region 车辆确认出厂数据推送 车位
        /// <summary>
        /// 车辆确认出厂数据推送
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CarOutConfirmPush()
        {
            _logger.LogInformation("接收CarOutConfirm车位推送数据");
            //获取加密的body内容
            StreamReader stream = new StreamReader(HttpContext.Request.Body);
            string body = await stream.ReadToEndAsync();

            #region 获取秘钥
            //获取请求头User-Agent
            string userAgent = HttpContext.Request.Headers["User-Agent"];
            string md5Str = userAgent.Substring(userAgent.LastIndexOf("_") + 1);
            //获取数字的数组
            string[] nums = Regex.Split(md5Str, @"[^0-9]+");
            nums = nums.Where(t => !string.IsNullOrEmpty(t)).ToArray();
            //定义秘钥起始位置
            int cipherNum = 0;
            //获取最后一个数字
            string lastNum = nums[nums.Length - 1];
            if (lastNum.Length > 1)
            {
                lastNum = lastNum.Substring(lastNum.Length - 1);
            }
            cipherNum = Convert.ToInt32(lastNum);
            //获取秘钥
            string key = md5Str.Substring(cipherNum, 16);
            #endregion

            //解密得到json数据
            string jsonBody = AesDecrypt(body, key);
            if (string.IsNullOrEmpty(jsonBody))
            {
                return Ok(new { data = "", resCode = "111111", resMsg = "解析失败！" });
            }
            //用预进厂Model解析
            CarPreComeIn preCar = JsonConvert.DeserializeObject<CarPreComeIn>(jsonBody);
            _logger.LogInformation($"CarOutConfirm推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName};道闸ID{preCar.sluiceDevChnId}");
            var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum && t.DispatchState >= 2);

            if (trTruck != null)
            {
                if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                {
                    var bayCodeList = trTruck.LoadBayCodeList.Split(',');
                    var parkingPlace = _dataContext.Set<TTrParkingPlace>().FirstOrDefault(t => bayCodeList.Contains(t.BayCode) && t.GateId == preCar.sluiceDevChnId);
                    //肯定不应为Null
                    var eqParking = _dataContext.Set<TEqGateParking>().FirstOrDefault(t => t.GateId == preCar.sluiceDevChnId);
                    var tele1341 = new Tele1341();
                    if (eqParking != null)
                    {
                        tele1341.PartnerId = new Ucp.Contracts.Key(eqParking.Code, eqParking.Code, 1);
                    }
                    tele1341.Payload.TruckNo = preCar.carNum;
                    tele1341.Payload.TruckType = 0;
                    //判断是装车或卸车
                    //退货信息，卸车
                    if (!string.IsNullOrEmpty(trTruck.TruckBackNo))
                    {
                        tele1341.Payload.TruckType = 1;
                    }
                    //库间倒运 根据状态判断卸车
                    if (!string.IsNullOrEmpty(trTruck.TransferNo))
                    {
                        var bayTran = _dataContext.Set<TPlBayTransfer>().FirstOrDefault(t => t.No == trTruck.TransferNo);
                        if (bayTran != null)
                        {
                            //状态 2 3 4 代表卸车
                            if (bayTran.ExecState > 1 && bayTran.ExecState < 5)
                            {
                                tele1341.Payload.TruckType = 1;
                            }
                        }
                        else
                        {
                            _logger.LogInformation($"库间倒运计划号{trTruck.TransferNo}/{trTruck.TruckNo}未找到计划");
                        }
                    }

                    //车辆已进入正确停车位  
                    if (parkingPlace != null)
                    {
                        trTruck.DispatchState = 5;
                        tele1341.Payload.TruckState = 0;
                    }
                    else //车辆未进入正确停车位
                    {
                        trTruck.DispatchState = 4;
                        tele1341.Payload.TruckState = 1;
                        tele1341.Payload.Remark = $"驶入错误停车位，请去{trTruck.ParkingNoSuggest}停车位";
                    }
                    _logger.LogInformation($"CarOutConfirm推送数据的车牌号：{preCar.carNum}道闸名称：{preCar.sluiceDevChnName}进入车位成功");
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(tele1341);

                    /* var chnIds = new List<string>() { "1000014$14$0$0", "1000068$14$0$0", "1000071$14$0$0" };*/ //16B 27A 27B
                    var chnIds = new List<string>() { "1000014$14$0$0", "1000068$14$0$0", "1000071$14$0$0" }; //16B 27A 27B
                    if (!string.IsNullOrEmpty(parkingPlace.CandidateTruck))
                    {
                        var candidateTruckList = parkingPlace.CandidateTruck.Split(',').ToList();
                        _logger.LogInformation($"CarOutConfirm推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除前候选车列表{string.Join(",", parkingPlace.CandidateTruck)}");
                        var index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        if (index == -1)
                        {
                            candidateTruckList.Add(preCar.carNum);
                            index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        }
                        if (index > 0)
                        {
                            _logger.LogInformation($"CarOutConfirm推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除车牌号(不包含)：{preCar.carNum}");
                            candidateTruckList.RemoveRange(0, index);
                        }
                        //if (!chnIds.Contains(preCar.sluiceDevChnId))
                        //{
                        //    if (index >= 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除车牌号(包含)：{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index + 1);
                        //    }

                        //}
                        //else
                        //{
                        //    if (index > 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除车牌号(不包含)：{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index);
                        //    }
                        //}
                        _logger.LogInformation($"CarOutConfirm推送数据的车牌号：{preCar.carNum}当前车位：{parkingPlace.ParkingPlaceId},移除后候选车列表{string.Join(",", parkingPlace.CandidateTruck)}");
                        parkingPlace.CandidateTruck = string.Join(",", candidateTruckList);
                    }
                    await _dataContext.SaveChangesAsync();
                }
            }
            // Ok(new { data = new { isOpen = "3" }, resCode = "000000", resMsg = "success" });
            return Ok();
        }
        #endregion

        #region 车辆预进/出厂解密
        /// <summary>
        /// ECB解密
        /// </summary>
        /// <param name="decData">加密数据</param>
        /// <param name="key">秘钥</param>
        /// <returns></returns>
        private string AesDecrypt(string decData, string key)
        {
            if (!string.IsNullOrEmpty(key) && key.Length == 16)
            {
                byte[] raw = Encoding.UTF8.GetBytes(key);
                byte[] decode64 = Convert.FromBase64String(decData);
                SymmetricAlgorithm des = Aes.Create();
                des.Key = Encoding.UTF8.GetBytes(key);
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = des.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(decode64, 0, decode64.Length);
                return Encoding.UTF8.GetString(resultArray);
            }
            return string.Empty;
        }
        #endregion

        #region 道闸控制

        /// <summary>
        /// 开关类型，1：开，2：关，3：停止，4：常开，5：常闭
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> GateControl(GateControlParas para)
        {
            // 检查访问令牌是否为空，如果为空则获取新的令牌
            if (string.IsNullOrWhiteSpace(_accessToken))
            {
                var tokenResult = await _gateTokenApi.GetToken("system");
                if (tokenResult != null)
                {
                    if (tokenResult.Success)
                    {
                        _accessToken = tokenResult.Data.AccessToken;
                    }
                    else
                    {
                        return Ok(new OperationResult(false, tokenResult.ErrMsg));
                    }
                }
            }
            // 如果访问令牌不为空，则调用门禁控制接口
            if (!string.IsNullOrWhiteSpace(_accessToken))
            {
                var result = await _gateApi.GateControl(para, _accessToken);
                if (result != null)
                {
                    return Ok(result);
                }
            }
            return NotFound();
        }

        /// <summary>
        /// 开关类型，1：开，2：关，3：停止，4：常开，5：常闭
        /// </summary>
        /// <param name="gateId"></param>
        /// <param name="type">开关类型，1：开，2：关，3：停止，4：常开，5：常闭</param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> GateOpenOrClose(string gateId, int type)
        {
            // 创建门禁控制参数对象
            var para = new GateControlParas();
            para.ChannelId = gateId;
            para.OperateType = type;
            // 检查访问令牌是否为空，如果为空则获取新的令牌
            if (string.IsNullOrWhiteSpace(_accessToken))
            {
                var tokenResult = await _gateTokenApi.GetToken("system");
                if (tokenResult != null)
                {
                    if (tokenResult.Success)
                    {
                        _accessToken = tokenResult.Data.AccessToken;
                    }
                    else
                    {
                        return Ok(new OperationResult(false, tokenResult.ErrMsg));
                    }
                }
            }
            // 如果访问令牌不为空，则调用门禁控制接口
            if (!string.IsNullOrWhiteSpace(_accessToken))
            {
                var result = await _gateApi.GateControl(para, _accessToken);
                if (result != null)
                {
                    return Ok(result);
                }
            }
            return NotFound();
        }


        /// <summary>
        /// 16库通过plc控制道闸，1：开，2：关
        /// </summary>
        /// <param name="gateId"></param>
        /// <param name="type">1：开，2：关</param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> GatePlcOpenOrClose(string gateId, int type)
        {
            GroundStateCommand gateStateCommand = new GroundStateCommand();
            gateStateCommand.PartnerId = new Key("Ground-PLC", "Ground-PLC", 0);
            gateStateCommand.StateType = 4;
            gateStateCommand.Name = gateId;
            gateStateCommand.Value = type;
            var mbs = _serviceProvider.GetService<MbsProxy>();
            await mbs.Publish(gateStateCommand);
            return Ok();
        }

        #endregion

        #region 摄像头报警推送
        /// <summary>
        /// 摄像头报警推送
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CameraAlarmPush()
        {
            StreamReader stream = new StreamReader(HttpContext.Request.Body);
            string jsonBody = await stream.ReadToEndAsync();
            if (!string.IsNullOrEmpty(jsonBody))
            {
                CameraInbreakResult result = JsonConvert.DeserializeObject<CameraInbreakResult>(jsonBody);
                if (result != null && result.data != null)
                {
                    var repo = _dataContext.Set<TRcCameraIds>();
                    int startIndex = result.data.alarmPic1.IndexOf("http");
                    int endIndex = result.data.alarmPic1.IndexOf("jpg");
                    string pic = result.data.alarmPic1.Substring(startIndex, endIndex + 3 - startIndex);

                    var id = IdWorkerGenerator.Instance.NextId().ToString();
                    var addModel = new TRcCameraIds()
                    {
                        Id = id,
                        AlarmState = result.data.alarmStat,
                        AlarmType = result.data.alarmType,
                        AlarmTime = result.data.alarmTime,
                        CameraCode = result.data.deviceCode,
                        CameraName = result.data.deviceName,
                        AlarmChannelName = result.data.alarmChannelName,
                        AlarmPicture = pic,
                        BayName = result.data.deviceName.Substring(0, 3),
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,
                        IsEnable = 1,
                        CreateUser = "API",
                        UpdateUser = "API",
                    };
                    var bayLight = _dataContext.Set<TTrTrafficLight>().FirstOrDefault(t => t.Name.Contains(addModel.BayName));
                    if (bayLight != null && bayLight.State == 1) //红灯亮时
                    {
                        repo.Add(addModel);
                        await _dataContext.SaveChangesAsync();
                    }


                    NoticeIconItem noticeIconItem = new()
                    {
                        Id = id,
                        Avatar = pic,
                        Title = $"{result.data.deviceName},非法入侵，请留意!",
                        Datetime = result.data.alarmTime,
                        Read = false,
                        Type = MessageType.Camera.ToString()
                    };
                    //await _hubContext.Clients.All.SendAsync("CameraAlarmPush", noticeIconItem);
                }
            }
            return Ok("推送成功");
        }
        #endregion

        #region 获取token
        private void GetToken()
        {

        }
        #endregion

    }
    /// <summary>
    /// 入侵摄像头推送的结果
    /// </summary>
    public class CameraInbreakResult
    {
        /// <summary>
        /// 推送结果数据
        /// </summary>
        public CameraInbreakData data { get; set; }
    }
    /// <summary>
    /// 入侵摄像头推送数据
    /// </summary>
    public class CameraInbreakData
    {
        /// <summary>
        /// 设备编码
        /// </summary>
        public string deviceCode { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string deviceName { get; set; }
        /// <summary>
        /// 通道编码
        /// </summary>
        public string alarmChannelCode { get; set; }
        /// <summary>
        /// 通道名称
        /// </summary>
        public string alarmChannelName { get; set; }
        /// <summary>
        /// 报警类型 302-绊线入侵  303-区域入侵
        /// </summary>
        public int alarmType { get; set; }
        /// <summary>
        /// 报警时间
        /// </summary>
        public string alarmTime { get; set; }
        /// <summary>
        /// 报警状态 1-报警产生 2-报警消失
        /// </summary>
        public int alarmStat { get; set; }
        /// <summary>
        /// 报警抓图地址
        /// </summary>
        public string alarmPic1 { get; set; }
    }

    /// <summary>
    /// 车辆预进厂推送类
    /// </summary>
    public class CarPreComeIn
    {
        /// <summary>
        /// 进厂车牌号
        /// </summary>
        public string carNum { get; set; }
        /// <summary>
        /// 道闸ID
        /// </summary>
        public string sluiceDevChnId { get; set; }
        /// <summary>
        /// 道闸名称
        /// </summary>
        public string sluiceDevChnName { get; set; }
    }
}
