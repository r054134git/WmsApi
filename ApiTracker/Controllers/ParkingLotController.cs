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

        #region ����Ԥ������������  ���
        /// <summary>
        /// ����Ԥ������������
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CarPreInPush()
        {
            _logger.LogInformation("���յ������������");
            //��ȡ���ܵ�body����
            try
            {
                StreamReader stream = new StreamReader(HttpContext.Request.Body);
                string body = await stream.ReadToEndAsync();

                if (string.IsNullOrEmpty(body))
                {
                    _logger.LogInformation($"���յ�����������ݣ�body����Ϊ��");
                }

                #region ��ȡ��Կ
                //��ȡ����ͷUser-Agent
                string userAgent = HttpContext.Request.Headers["User-Agent"];
                string md5Str = userAgent.Substring(userAgent.LastIndexOf("_") + 1);
                //��ȡ���ֵ�����
                string[] nums = Regex.Split(md5Str, @"[^0-9]+");
                nums = nums.Where(t => !string.IsNullOrEmpty(t)).ToArray();
                //������Կ��ʼλ��
                int cipherNum = 0;
                //��ȡ���һ������
                string lastNum = nums[nums.Length - 1];
                if (lastNum.Length > 1)
                {
                    lastNum = lastNum.Substring(lastNum.Length - 1);
                }
                _logger.LogInformation($"���յ�����������ݣ���ȡ���һ������{lastNum}");
                cipherNum = Convert.ToInt32(lastNum);
                //��ȡ��Կ
                string key = md5Str.Substring(cipherNum, 16);
                #endregion

                //���ܵõ�json����
                string jsonBody = AesDecrypt(body, key);
                if (string.IsNullOrEmpty(jsonBody))
                {
                    _logger.LogInformation($"���յ�����������ݣ�����ʧ��");
                    return Ok(new { data = "", resCode = "111111", resMsg = "����ʧ�ܣ�" });
                }
                CarPreComeIn preCar = JsonConvert.DeserializeObject<CarPreComeIn>(jsonBody);
                //preCar.carNum = "³L90720";
                _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}");

                string bayNo = preCar.sluiceDevChnName.Substring(0, 2);
                var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum);
                if (trTruck != null)
                {
                    trTruck.DispatchState = 3; // �������
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
                    _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName} ��ǰ�ȴ���⳵����{string.Join(",", truckNos)}");
                    var curQueueInfo = bayQueueList.FirstOrDefault(t => t.TruckNo == preCar.carNum);
                    if (curQueueInfo != null)
                    {
                        curQueueInfo.DispatchStepState = 3;
                        curQueueInfo.UpdateTime = DateTime.Now;
                        curQueueInfo.EntryBayTime = DateTime.Now;
                        _dataContext.Update(curQueueInfo);

                        //����ⷿ�˹������Ŷ�״̬�ĳ���Ϊ��
                        if (curQueueInfo.IsMoreBay == 1)
                        {
                            var otherBayList = _dataContext.Set<TTrTruckBayQueue>().Where(t => t.BayCode != curQueueInfo.BayCode && t.MainLoadingNo == curQueueInfo.MainLoadingNo && (t.DispatchStepState == 1 || t.DispatchStepState == 2)).ToList();
                            if (otherBayList.Count > 0)
                            {
                                foreach (var otherBay in otherBayList)
                                {
                                    otherBay.DispatchStepState = 0;
                                    otherBay.UpdateTime = DateTime.Now;
                                    otherBay.Remark += ";δ��˳��ⷿ�Ŷ�";
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
                        _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}��������ɹ�");
                        return Ok(new { data = new { isOpen = "1" }, resCode = "000000", resMsg = "success" });
                        //if (curQueueInfo.BayCode == "16" || curQueueInfo.BayCode == "17")
                        //{
                        //    return Ok(new { data = new { isOpen = "1" }, resCode = "000000", resMsg = "success" });
                        //}
                    }
                }
                else
                {
                    _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}δ�յ��ȴ����ĳ���");
                }

                #region Old ����������
                //���Ids �ж��ǳ����
                //var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum);
                //var repoLight = _dataContext.Set<TTrTrafficLight>().AsNoTracking();
                //var plcName = "Light.W16.1";
                //if (preCar.sluiceDevChnName.Contains("25"))
                //{
                //    plcName = "Light.W25.1";
                //}
                //var trafficlight = await repoLight.FirstOrDefaultAsync(t => t.PlcName == plcName);

                ////��բ̧��Ҫ��1���г�����2��ͣ��λ���У�3����ǰ��բ�ɽ���  (&& trTruck.CraneEnabled == 1 ע����)
                //if (trTruck != null)
                //{
                //    var allowBayCodes = GetVerifyBayCodes(trTruck, preCar.sluiceDevChnId);
                //    if (allowBayCodes != null && allowBayCodes.Count > 0)
                //    {
                //        _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName},װ���ⷿ�б�{string.Join(",", allowBayCodes)}");
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
                //            _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{park.ParkingPlaceId},��ѡ���б�{string.Join(",", park.CandidateTruck)}");
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
                //                _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}��ǰ���̵�{trafficlight.Name}������ȴ�10��������֤");
                //                await Task.Delay(10000);
                //                trafficlight = await repoLight.FirstOrDefaultAsync(t => t.PlcName == plcName);
                //                goto checklight;
                //            }
                //            trTruck.DispatchState = 3; // �������
                //            trTruck.ArriveTime = DateTime.Now;
                //            await _dataContext.SaveChangesAsync();
                //            _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}��������ɹ�");
                //            await GateControl(new GateControlParas { ChannelId = preCar.sluiceDevChnId, OperateType = 1 });
                //            return Ok(new { data = new { isOpen = "1" }, resCode = "000000", resMsg = "success" });
                //        }
                //    }
                //    else
                //    {
                //        _logger.LogInformation($"�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}����allowBayCodesΪnull");
                //    }
                //}
                #endregion
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"���յ�����������ݣ������쳣��{ex.Message}");
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
                        _logger.LogInformation($"�������ݵĳ��ƺţ�{trTruck.TruckNo},ʵʱװ�ؿⷿ��{string.Join(',', loadBayCodes)},trTruck.LoadBayCodeListװ�ؿⷿ��{trTruck.LoadBayCodeList}");
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

        #region ����Ԥ������������ ��λ
        /// <summary>
        /// ����Ԥ������������
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CarPreOutPush()
        {
            _logger.LogInformation("����CarPreOut��λ��������");
            //��ȡ���ܵ�body����
            StreamReader stream = new StreamReader(HttpContext.Request.Body);
            string body = await stream.ReadToEndAsync();

            #region ��ȡ��Կ
            //��ȡ����ͷUser-Agent
            string userAgent = HttpContext.Request.Headers["User-Agent"];
            string md5Str = userAgent.Substring(userAgent.LastIndexOf("_") + 1);
            //��ȡ���ֵ�����
            string[] nums = Regex.Split(md5Str, @"[^0-9]+");
            nums = nums.Where(t => !string.IsNullOrEmpty(t)).ToArray();
            //������Կ��ʼλ��
            int cipherNum = 0;
            //��ȡ���һ������
            string lastNum = nums[nums.Length - 1];
            if (lastNum.Length > 1)
            {
                lastNum = lastNum.Substring(lastNum.Length - 1);
            }
            cipherNum = Convert.ToInt32(lastNum);
            //��ȡ��Կ
            string key = md5Str.Substring(cipherNum, 16);
            #endregion

            //���ܵõ�json����
            string jsonBody = AesDecrypt(body, key);
            if (string.IsNullOrEmpty(jsonBody))
            {
                return Ok(new { data = "", resCode = "111111", resMsg = "����ʧ�ܣ�" });
            }
            //��Ԥ����Model����
            CarPreComeIn preCar = JsonConvert.DeserializeObject<CarPreComeIn>(jsonBody);
            _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName};��բID{preCar.sluiceDevChnId}");
            // t.DispatchState == 2�ǿ�λ�Ⱥ������ϲ�Ӧ��̧��
            var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum && t.DispatchState >= 2);

            if (trTruck != null)
            {
                if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                {
                    var bayCodeList = trTruck.LoadBayCodeList.Split(',');
                    var parkingPlace = _dataContext.Set<TTrParkingPlace>().FirstOrDefault(t => bayCodeList.Contains(t.BayCode) && t.GateId == preCar.sluiceDevChnId);
                    //�϶���ӦΪNull
                    var eqParking = _dataContext.Set<TEqGateParking>().FirstOrDefault(t => t.GateId == preCar.sluiceDevChnId);
                    var tele1341 = new Tele1341();
                    if (eqParking != null)
                    {
                        tele1341.PartnerId = new Ucp.Contracts.Key(eqParking.Code, eqParking.Code, 1);
                    }
                    tele1341.Payload.TruckNo = preCar.carNum;
                    tele1341.Payload.TruckType = 0;
                    //�ж���װ����ж��
                    //�˻���Ϣ��ж��
                    if (!string.IsNullOrEmpty(trTruck.TruckBackNo))
                    {
                        tele1341.Payload.TruckType = 1;
                    }
                    //��䵹�� ����״̬�ж�ж��
                    if (!string.IsNullOrEmpty(trTruck.TransferNo))
                    {
                        var bayTran = _dataContext.Set<TPlBayTransfer>().FirstOrDefault(t => t.No == trTruck.TransferNo);
                        if (bayTran != null)
                        {
                            //״̬ 2 3 4 ����ж��
                            if (bayTran.ExecState > 1 && bayTran.ExecState < 5)
                            {
                                tele1341.Payload.TruckType = 1;
                            }
                        }
                        else
                        {
                            _logger.LogInformation($"��䵹�˼ƻ���{trTruck.TransferNo}/{trTruck.TruckNo}δ�ҵ��ƻ�");
                        }
                    }

                    //�����ѽ�����ȷͣ��λ  
                    if (parkingPlace != null)
                    {
                        trTruck.DispatchState = 5;
                        tele1341.Payload.TruckState = 0;
                    }
                    else //����δ������ȷͣ��λ
                    {
                        trTruck.DispatchState = 4;
                        tele1341.Payload.TruckState = 1;
                        tele1341.Payload.Remark = $"ʻ�����ͣ��λ����ȥ{trTruck.ParkingNoSuggest}ͣ��λ";
                    }
                    _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}���복λ�ɹ�");
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(tele1341);

                    var chnIds = new List<string>() { "1000014$14$0$0", "1000068$14$0$0", "1000071$14$0$0" }; //16B 27A 27B
                    if (!string.IsNullOrEmpty(parkingPlace.CandidateTruck))
                    {
                        var candidateTruckList = parkingPlace.CandidateTruck.Split(',').ToList();
                        _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ�ǰ��ѡ���б�{string.Join(",", parkingPlace.CandidateTruck)}");
                        var index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        if (index == -1)
                        {
                            candidateTruckList.Add(preCar.carNum);
                            index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        }
                        if (index > 0)
                        {
                            _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ƺ�(������)��{preCar.carNum}");
                            candidateTruckList.RemoveRange(0, index);
                        }
                        //if (!chnIds.Contains(preCar.sluiceDevChnId))
                        //{
                        //    if (index >= 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ƺ�(����)��{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index + 1);
                        //    }

                        //}
                        //else
                        //{
                        //    if (index > 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ƺ�(������)��{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index);
                        //    }
                        //}
                        _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ѡ���б�{string.Join(",", parkingPlace.CandidateTruck)}");
                        parkingPlace.CandidateTruck = string.Join(",", candidateTruckList);
                    }
                    await _dataContext.SaveChangesAsync();
                }
            }
            return Ok(new { data = new { isOpen = "2" }, resCode = "000000", resMsg = "success" });
            //return Ok();
        }
        #endregion

        #region ����ȷ�ϳ����������� ��λ
        /// <summary>
        /// ����ȷ�ϳ�����������
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult> CarOutConfirmPush()
        {
            _logger.LogInformation("����CarOutConfirm��λ��������");
            //��ȡ���ܵ�body����
            StreamReader stream = new StreamReader(HttpContext.Request.Body);
            string body = await stream.ReadToEndAsync();

            #region ��ȡ��Կ
            //��ȡ����ͷUser-Agent
            string userAgent = HttpContext.Request.Headers["User-Agent"];
            string md5Str = userAgent.Substring(userAgent.LastIndexOf("_") + 1);
            //��ȡ���ֵ�����
            string[] nums = Regex.Split(md5Str, @"[^0-9]+");
            nums = nums.Where(t => !string.IsNullOrEmpty(t)).ToArray();
            //������Կ��ʼλ��
            int cipherNum = 0;
            //��ȡ���һ������
            string lastNum = nums[nums.Length - 1];
            if (lastNum.Length > 1)
            {
                lastNum = lastNum.Substring(lastNum.Length - 1);
            }
            cipherNum = Convert.ToInt32(lastNum);
            //��ȡ��Կ
            string key = md5Str.Substring(cipherNum, 16);
            #endregion

            //���ܵõ�json����
            string jsonBody = AesDecrypt(body, key);
            if (string.IsNullOrEmpty(jsonBody))
            {
                return Ok(new { data = "", resCode = "111111", resMsg = "����ʧ�ܣ�" });
            }
            //��Ԥ����Model����
            CarPreComeIn preCar = JsonConvert.DeserializeObject<CarPreComeIn>(jsonBody);
            _logger.LogInformation($"CarOutConfirm�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName};��բID{preCar.sluiceDevChnId}");
            var trTruck = await _dataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.TruckNo == preCar.carNum && t.DispatchState >= 2);

            if (trTruck != null)
            {
                if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                {
                    var bayCodeList = trTruck.LoadBayCodeList.Split(',');
                    var parkingPlace = _dataContext.Set<TTrParkingPlace>().FirstOrDefault(t => bayCodeList.Contains(t.BayCode) && t.GateId == preCar.sluiceDevChnId);
                    //�϶���ӦΪNull
                    var eqParking = _dataContext.Set<TEqGateParking>().FirstOrDefault(t => t.GateId == preCar.sluiceDevChnId);
                    var tele1341 = new Tele1341();
                    if (eqParking != null)
                    {
                        tele1341.PartnerId = new Ucp.Contracts.Key(eqParking.Code, eqParking.Code, 1);
                    }
                    tele1341.Payload.TruckNo = preCar.carNum;
                    tele1341.Payload.TruckType = 0;
                    //�ж���װ����ж��
                    //�˻���Ϣ��ж��
                    if (!string.IsNullOrEmpty(trTruck.TruckBackNo))
                    {
                        tele1341.Payload.TruckType = 1;
                    }
                    //��䵹�� ����״̬�ж�ж��
                    if (!string.IsNullOrEmpty(trTruck.TransferNo))
                    {
                        var bayTran = _dataContext.Set<TPlBayTransfer>().FirstOrDefault(t => t.No == trTruck.TransferNo);
                        if (bayTran != null)
                        {
                            //״̬ 2 3 4 ����ж��
                            if (bayTran.ExecState > 1 && bayTran.ExecState < 5)
                            {
                                tele1341.Payload.TruckType = 1;
                            }
                        }
                        else
                        {
                            _logger.LogInformation($"��䵹�˼ƻ���{trTruck.TransferNo}/{trTruck.TruckNo}δ�ҵ��ƻ�");
                        }
                    }

                    //�����ѽ�����ȷͣ��λ  
                    if (parkingPlace != null)
                    {
                        trTruck.DispatchState = 5;
                        tele1341.Payload.TruckState = 0;
                    }
                    else //����δ������ȷͣ��λ
                    {
                        trTruck.DispatchState = 4;
                        tele1341.Payload.TruckState = 1;
                        tele1341.Payload.Remark = $"ʻ�����ͣ��λ����ȥ{trTruck.ParkingNoSuggest}ͣ��λ";
                    }
                    _logger.LogInformation($"CarOutConfirm�������ݵĳ��ƺţ�{preCar.carNum}��բ���ƣ�{preCar.sluiceDevChnName}���복λ�ɹ�");
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(tele1341);

                    /* var chnIds = new List<string>() { "1000014$14$0$0", "1000068$14$0$0", "1000071$14$0$0" };*/ //16B 27A 27B
                    var chnIds = new List<string>() { "1000014$14$0$0", "1000068$14$0$0", "1000071$14$0$0" }; //16B 27A 27B
                    if (!string.IsNullOrEmpty(parkingPlace.CandidateTruck))
                    {
                        var candidateTruckList = parkingPlace.CandidateTruck.Split(',').ToList();
                        _logger.LogInformation($"CarOutConfirm�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ�ǰ��ѡ���б�{string.Join(",", parkingPlace.CandidateTruck)}");
                        var index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        if (index == -1)
                        {
                            candidateTruckList.Add(preCar.carNum);
                            index = candidateTruckList.FindIndex(t => t == preCar.carNum);
                        }
                        if (index > 0)
                        {
                            _logger.LogInformation($"CarOutConfirm�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ƺ�(������)��{preCar.carNum}");
                            candidateTruckList.RemoveRange(0, index);
                        }
                        //if (!chnIds.Contains(preCar.sluiceDevChnId))
                        //{
                        //    if (index >= 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ƺ�(����)��{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index + 1);
                        //    }

                        //}
                        //else
                        //{
                        //    if (index > 0)
                        //    {
                        //        _logger.LogInformation($"CarPreOut�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ƺ�(������)��{preCar.carNum}");
                        //        candidateTruckList.RemoveRange(0, index);
                        //    }
                        //}
                        _logger.LogInformation($"CarOutConfirm�������ݵĳ��ƺţ�{preCar.carNum}��ǰ��λ��{parkingPlace.ParkingPlaceId},�Ƴ����ѡ���б�{string.Join(",", parkingPlace.CandidateTruck)}");
                        parkingPlace.CandidateTruck = string.Join(",", candidateTruckList);
                    }
                    await _dataContext.SaveChangesAsync();
                }
            }
            // Ok(new { data = new { isOpen = "3" }, resCode = "000000", resMsg = "success" });
            return Ok();
        }
        #endregion

        #region ����Ԥ��/��������
        /// <summary>
        /// ECB����
        /// </summary>
        /// <param name="decData">��������</param>
        /// <param name="key">��Կ</param>
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

        #region ��բ����

        /// <summary>
        /// �������ͣ�1������2���أ�3��ֹͣ��4��������5������
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> GateControl(GateControlParas para)
        {
            // �����������Ƿ�Ϊ�գ����Ϊ�����ȡ�µ�����
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
            // ����������Ʋ�Ϊ�գ�������Ž����ƽӿ�
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
        /// �������ͣ�1������2���أ�3��ֹͣ��4��������5������
        /// </summary>
        /// <param name="gateId"></param>
        /// <param name="type">�������ͣ�1������2���أ�3��ֹͣ��4��������5������</param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> GateOpenOrClose(string gateId, int type)
        {
            // �����Ž����Ʋ�������
            var para = new GateControlParas();
            para.ChannelId = gateId;
            para.OperateType = type;
            // �����������Ƿ�Ϊ�գ����Ϊ�����ȡ�µ�����
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
            // ����������Ʋ�Ϊ�գ�������Ž����ƽӿ�
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
        /// 16��ͨ��plc���Ƶ�բ��1������2����
        /// </summary>
        /// <param name="gateId"></param>
        /// <param name="type">1������2����</param>
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

        #region ����ͷ��������
        /// <summary>
        /// ����ͷ��������
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
                    if (bayLight != null && bayLight.State == 1) //�����ʱ
                    {
                        repo.Add(addModel);
                        await _dataContext.SaveChangesAsync();
                    }


                    NoticeIconItem noticeIconItem = new()
                    {
                        Id = id,
                        Avatar = pic,
                        Title = $"{result.data.deviceName},�Ƿ����֣�������!",
                        Datetime = result.data.alarmTime,
                        Read = false,
                        Type = MessageType.Camera.ToString()
                    };
                    //await _hubContext.Clients.All.SendAsync("CameraAlarmPush", noticeIconItem);
                }
            }
            return Ok("���ͳɹ�");
        }
        #endregion

        #region ��ȡtoken
        private void GetToken()
        {

        }
        #endregion

    }
    /// <summary>
    /// ��������ͷ���͵Ľ��
    /// </summary>
    public class CameraInbreakResult
    {
        /// <summary>
        /// ���ͽ������
        /// </summary>
        public CameraInbreakData data { get; set; }
    }
    /// <summary>
    /// ��������ͷ��������
    /// </summary>
    public class CameraInbreakData
    {
        /// <summary>
        /// �豸����
        /// </summary>
        public string deviceCode { get; set; }
        /// <summary>
        /// �豸����
        /// </summary>
        public string deviceName { get; set; }
        /// <summary>
        /// ͨ������
        /// </summary>
        public string alarmChannelCode { get; set; }
        /// <summary>
        /// ͨ������
        /// </summary>
        public string alarmChannelName { get; set; }
        /// <summary>
        /// �������� 302-��������  303-��������
        /// </summary>
        public int alarmType { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string alarmTime { get; set; }
        /// <summary>
        /// ����״̬ 1-�������� 2-������ʧ
        /// </summary>
        public int alarmStat { get; set; }
        /// <summary>
        /// ����ץͼ��ַ
        /// </summary>
        public string alarmPic1 { get; set; }
    }

    /// <summary>
    /// ����Ԥ����������
    /// </summary>
    public class CarPreComeIn
    {
        /// <summary>
        /// �������ƺ�
        /// </summary>
        public string carNum { get; set; }
        /// <summary>
        /// ��բID
        /// </summary>
        public string sluiceDevChnId { get; set; }
        /// <summary>
        /// ��բ����
        /// </summary>
        public string sluiceDevChnName { get; set; }
    }
}
