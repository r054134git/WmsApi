using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Contracts;
using Wms.Telegram;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.IO;
using MiniExcelLibs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net;
using System.Collections;
using Microsoft.IdentityModel.Tokens;
using MiniExcelLibs.OpenXml;
using Newtonsoft.Json.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Data.Common;
using System.Data;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using MassTransit;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("tracker/[controller]/[action]")]
    public class TTrLocationMaterialController : EntityControllerBase<TTrLocationMaterial, TTrLocationMaterialReadModel, TTrLocationMaterialCreateModel, TTrLocationMaterialUpdateModel>
    {
        private readonly IHubContext<ChatHub> _hubContext;
        public TTrLocationMaterialController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrLocationMaterialCreateModel> createValidator, IValidator<TTrLocationMaterialUpdateModel> updateValidator, IHubContext<ChatHub> hubContext)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
            _hubContext = hubContext;
        }

        /// <summary>
        /// 获取跨内的库位钢卷对应关系
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetLmMappingOfBay(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.BayId == bayId && t.IsEnable == 1);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetLmMappingOfBayWPF(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.BayId == bayId);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 根据物料号请求MES卷信息
        /// </summary>
        /// <param name="materialNo"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> ReqMesMatInfo(string materialNo)
        {
            if (string.IsNullOrEmpty(materialNo))
            {
                return new OperationResult(false, "卷号为空");
            }
            //MES请求卷信息
            var mbs = ServiceProvider.GetService<MbsProxy>();
            var teleWMBM02 = new TeleWMBM02
            {
                Payload = new()
                {
                    CoilNo = materialNo
                }
            };
            await mbs.Publish(teleWMBM02);
            return new OperationResult(true, $"卷号{materialNo}信息请求成功");
        }

        [HttpPut("")]
        public async Task<ActionResult<OperationResult>>
           UpdateMaterialLock(string id, string materialNo, int lockMark, string lockReason, CancellationToken cancellationToken)
        {
            var repoTr = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
            var plMaterial = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == materialNo, cancellationToken);
            if (repoTr != null)
            {
                repoTr.LockMark = lockMark;
                repoTr.LockReason = lockReason;
                if (plMaterial != null)
                {
                    plMaterial.LockMark = lockMark;
                    plMaterial.LockReason = lockReason;
                }
                await DataContext.SaveChangesAsync();
                return new OperationResult(true, "该物料锁定成功！");
            }
            return new OperationResult(false, "物料表没有该物料！");
        }

        [HttpPut("")]
        public async Task<ActionResult<OperationResult>>
           UpdateLocationLoad(string locationName, int isLoadEnable, CancellationToken cancellationToken)
        {
            var repoTr = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.LocationName == locationName);
            if (repoTr != null)
            {
                repoTr.IsLoadEnable = isLoadEnable;
                await DataContext.SaveChangesAsync();
                return new OperationResult(true, "下线类型修改成功");
            }
            return new OperationResult(false, "操作异常");
        }
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>>
           CheckAreaLM(string bayCode, decimal minX, decimal maxX, CancellationToken cancellationToken)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoPl = DataContext.Set<TPlStackTranfer>();
            var areaLm = repoTr.Where(t => t.BayCode == bayCode && t.PointX > minX && t.PointX < maxX).ToList();
            if (areaLm != null)
            {
                var inStockLists = areaLm.Where(t => t.Type == 2).ToList();
                var probability = Math.Round((double)inStockLists.Count() / (double)areaLm.Count, 2);
                if (probability > 0.50)
                {
                    var pl = new TPlStackTranfer()
                    {
                        Id = DateTime.Now.ToFileTime().ToString(),
                        BayId = areaLm.FirstOrDefault().BayId,
                        AreaId = areaLm.FirstOrDefault().AreaId,
                        StartStackId = inStockLists.OrderBy(t => t.RowNo).FirstOrDefault().StackId,
                        EndStackId = inStockLists.OrderByDescending(t => t.RowNo).FirstOrDefault().StackId,
                        StartColId = inStockLists.OrderBy(t => t.ColNo).FirstOrDefault().LocationId,
                        EndColId = inStockLists.OrderByDescending(t => t.ColNo).FirstOrDefault().LocationId,
                        FromPointX = inStockLists.OrderBy(t => t.ColNo).FirstOrDefault().PointX,
                        FromPointY = inStockLists.OrderBy(t => t.RowNo).FirstOrDefault().PointY,
                        DestPointX = inStockLists.OrderByDescending(t => t.ColNo).FirstOrDefault().PointX,
                        DestPointY = inStockLists.OrderByDescending(t => t.RowNo).FirstOrDefault().PointY,
                        Type = 1,
                        PlanCount = inStockLists.Count(),
                        TodoCount = inStockLists.Count(),
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"

                    };
                    repoPl.Add(pl);
                    await DataContext.SaveChangesAsync();
                    return new OperationResult(false, null);
                }
                return new OperationResult(true, null);
            }
            return new OperationResult(true, null);
        }

        /// <summary>
        /// 客户端库存信息
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetAllPageLMs(CancellationToken cancellationToken)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoPl = DataContext.Set<TPlMaterial>();
            var trLMs = repoTr.ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).ToList();
            foreach (var lm in trLMs)
            {
                if (lm.Type != 0)
                {
                    var pl = repoPl.Where(t => t.Id == lm.MaterialId).FirstOrDefault();
                    if (pl != null && pl.DefectType != null)
                    {
                        lm.DefectType = (int)pl.DefectType;
                    }
                }
            }
            var pageTrLMs = trLMs;
            return Ok(pageTrLMs);
        }

        /// <summary>
        /// 客户端库存信息编辑
        /// </summary>
        /// <returns></returns>
        [TokenActionFilter]
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>>
        UpdateMaterialEdit(string id, string materialNo, int type, int isNot, CancellationToken cancellationToken)
        {
            var identityName = User.GetUserName();

            var repoTr = DataContext.Set<TTrLocationMaterial>().FirstOrDefault(t => t.Id == id);
            if (repoTr.AreaCode == "0Z")
            {
                var mbs = ServiceProvider.GetService<MbsProxy>();

                var payLoad = new CplMaterialLocUpdate()
                {
                    BayCode = repoTr.BayCode,
                    AreaCode = repoTr.AreaCode,
                    ColNo = ((byte)repoTr.ColNo),
                    LoadMatType = (byte)(string.IsNullOrEmpty(materialNo) ? 2 : 1),//退料
                    MaterialNo = materialNo
                };
                await mbs.Publish(payLoad);
            }
            var trMaterial = DataContext.Set<TTrLocationMaterial>().FirstOrDefault(t => t.MaterialNo == materialNo && t.Type == 2);
            var repoPl = DataContext.Set<TPlMaterial>().FirstOrDefault(t => t.No == materialNo);
            var repoLog = DataContext.Set<TRcLog>();
            var dataContextPl = DataContext.Set<TPlMaterial>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            //清空卷号
            if (materialNo == null || type == 0)
            {
                repoTr.UpdateUser = identityName;
                CommClearLocMat(repoTr);

                var log = new TRcLog
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    Source = "API",
                    WarningLevel = "INFO",
                    Message = $"删除库位库存信息{repoTr.LocationName},{identityName}"
                };
                repoLog.Add(log);

                await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, "卷号已清空");
            }
            //不覆盖式修改
            if (isNot == 0 && repoTr != null)
            {
                if (trMaterial != null)
                {
                    return new OperationResult(false, $"卷号{trMaterial.MaterialNo}已在库位{trMaterial.LocationName}入库");
                }
                if (repoPl == null)
                {
                    return new OperationResult(false, $"卷号{trMaterial.MaterialNo}不存在");
                }
                repoTr.Type = type;
                repoTr.MaterialId = repoPl.Id;
                repoTr.MaterialNo = materialNo;
                repoTr.Thick = repoPl.Thick;
                repoTr.Weight = repoPl.Weight;
                repoTr.Width = repoPl.Width;
                repoTr.Diameter = repoPl.Diameter;
                repoTr.Length = repoPl.Length;
                repoTr.InnerDiameter = repoPl.InnerDiameter;
                repoTr.OrderNo = repoPl.OrderNo;
                repoTr.SteelGrade = repoPl.SteelGrade;
                repoTr.MatDisposeCode = repoPl.MatDisposeCode;
                repoTr.ComplexDecideCode = repoPl.ComplexDecideCode;

            }
            //覆盖式更改
            if (isNot == 1 && repoTr != null && type != 0)
            {
                string newMatOldLoc = "";
                if (trMaterial != null)
                {
                    newMatOldLoc = trMaterial.LocationName;
                    CommClearLocMat(trMaterial);

                    var delLog = new TRcLog
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        Source = "API",
                        WarningLevel = "INFO",
                        Message = $"删除库位库存信息{trMaterial.LocationName}卷号{materialNo},操作人{identityName}"
                    };
                    repoLog.Add(delLog);
                    repoLocMat.Update(trMaterial);
                }
                if (repoPl == null)
                {
                    repoPl = new TPlMaterial
                    {
                        Id = DateTime.Now.ToFileTime().ToString(),
                        No = materialNo,
                        Thick = 1,
                        Width = 1,
                        Weight = 1,
                        MaterialLocationOwner = "C3",
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"
                    };
                    dataContextPl.Add(repoPl);
                }
                string oldMatNo = repoTr.MaterialNo;
                //MES请求卷信息
                var mbs = ServiceProvider.GetService<MbsProxy>();
                var teleWMBM02 = new TeleWMBM02
                {
                    Payload = new()
                    {
                        CoilNo = materialNo
                    }
                };
                await mbs.Publish(teleWMBM02);
                var log = new TRcLog
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    Source = "API",
                    WarningLevel = "INFO",
                    Message = $"人工修改库位，原卷号{oldMatNo}，新卷号{repoPl.No}"
                };
                repoLog.Add(log);

                var record = new TRcMaterialEvent
                {
                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                    MaterialId = "",
                    Dt = DateTime.Now,
                    MaterialNo = repoPl.No,
                    OperationType = "人工",
                    ContentType = "人工更正卷号",
                    FromLocationName = newMatOldLoc,
                    ToLocationName = repoTr.LocationName,
                    Description = $"人工更正卷号，原卷号{oldMatNo}，新卷号的原库位{newMatOldLoc} ，操作员{identityName}",
                    FromPosition = "",
                    ToPosition = "",
                    Result = "成功"
                };
                repoMatEv.Add(record);
                CommUpdateMatToLoc(repoTr, repoPl);
                repoLocMat.Update(repoTr);
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "信息已更改");
        }

        /// <summary>
        /// 更改钢卷信息，库存状态
        /// </summary>
        [HttpPut("")]
        public async Task<ActionResult<TTrLocationMaterialReadModel>>
            UpdateMaterialState(string locationId, string coilNo, PackTypes packType, int isHandlePack, string user, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlMaterial>();
            var repoRc = DataContext.Set<TRcMaterial>();

            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoEvent = DataContext.Set<TRcMaterialEvent>();
            var repoMessage = DataContext.Set<TTrMessageSend>();
            var repoLog = DataContext.Set<TRcLog>();

            var tr = repoTr.Where(t => t.LocationId == locationId).FirstOrDefault();
            if (tr == null)
            {
                return NotFound();
            }
            var ownerMaterial = tr.MaterialNo;
            var lastUser = tr.UpdateUser;
            var lastTime = tr.UpdateTime;
            if (string.IsNullOrWhiteSpace(coilNo))
            {
                CommClearLocMat(tr);

                var log = new TRcLog
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    Source = "API",
                    WarningLevel = "INFO",
                    Message = $"UpdateMaterialState删除库位信息{tr.LocationName}"
                };
                repoLog.Add(log);

                var record = new TRcMaterialEvent
                {
                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                    MaterialId = "",
                    Dt = DateTime.Now,
                    MaterialNo = ownerMaterial,
                    OperationType = "人工",
                    ContentType = "人工清空",
                    FromLocationName = tr.LocationName,
                    ToLocationName = "",
                    Description = $"人工清空库位{tr.LocationName}原卷号{ownerMaterial} ，操作员{user}",
                    FromPosition = "",
                    ToPosition = "",
                    Result = "成功"
                };
                repoEvent.Add(record);
            }

            else if (tr.MaterialNo != coilNo)
            {
                var material = repoPl.Where(t => t.No == coilNo).FirstOrDefault();
                if (material == null)
                {
                    material = new TPlMaterial
                    {
                        Id = DateTime.Now.ToFileTime().ToString(),
                        No = coilNo,
                        Thick = 1,
                        Width = 1,
                        Weight = 1,
                        MaterialLocationOwner = "C3",
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"
                    };
                    repoPl.Add(material);

                    var record = new TRcMaterialEvent
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        MaterialId = material.Id,
                        Dt = DateTime.Now,
                        MaterialNo = coilNo,
                        OperationType = "",
                        ContentType = "人工添加，无钢卷信息",
                        MaterialNoOld = ownerMaterial,
                        FromLocationName = tr.LocationName,
                        ToLocationName = "",
                        Description = $"人工修改库位信息 原卷号{ownerMaterial} ，操作员：{user}",
                        FromPosition = "",
                        ToPosition = "",
                        Result = "成功"
                    };
                    repoEvent.Add(record);
                }

                if (material != null)
                {
                    await SendMaterialInfo(coilNo, cancellationToken);
                    string prevLocation = string.Empty;
                    var lms = repoTr.Where(t => t.MaterialId == material.Id && t.Type == 2).ToList();
                    if (lms != null && lms.Count > 0)
                    {
                        foreach (var lm in lms.ToList())
                        {
                            CommClearLocMat(lm);
                            prevLocation = lm.LocationName;
                            lm.Type = (int)MaterialStatusTypes.None;
                            lm.UpdateTime = DateTime.Now;
                            lm.UpdateUser = "API";

                            var log = new TRcLog
                            {
                                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                Dt = DateTime.Now,
                                Source = "API",
                                EventNo = "1000",
                                WarningLevel = "INFO",
                                Message = $"UpdateMaterialState删除库位信息{lm.LocationName}"
                            };
                            repoLog.Add(log);
                        }
                    }

                    //tr = Mapper.Map(material, tr);
                    CommUpdateMatToLoc(tr, material);
                    tr.Type = (int)MaterialStatusTypes.InStock;
                    tr.UpdateTime = DateTime.Now;
                    tr.UpdateUser = "API";

                    var record = new TRcMaterialEvent
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        MaterialId = material.Id,
                        Dt = DateTime.Now,
                        MaterialNo = material.No,
                        OperationType = "人工",
                        ContentType = "人工更正",
                        FromLocationName = prevLocation,
                        ToLocationName = tr.LocationName,
                        Description = $"人工修改库位，操作员：,last{lastUser}{lastTime}",
                        FromPosition = "",
                        ToPosition = "",
                        Result = "成功"
                    };
                    repoEvent.Add(record);

                    var message = new TTrMessageSend
                    {
                        MessageId = "WMBM01",
                        MaterialNo = material.No,
                        DestLocation = tr.LocationName,
                        BayCode = tr.BayCode,
                        Area = tr.BayCode + tr.AreaCode,
                        BusinessName = tr.OwnerBussinessName,
                        Floor = tr.FloorNo.ToString(),
                        Col = tr.ColNo.ToString(),
                        Row = tr.RowNo.ToString(),
                        Type = "2",
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API",
                        Operator = MesUser.GetUserName(tr.OwnerBussinessName),
                    };
                    var reqMat = repoPl.Where(t => t.No == coilNo).FirstOrDefault();
                    if (reqMat != null && (string.IsNullOrEmpty(reqMat.MaterialBussinessOwner) || reqMat.MaterialBussinessOwner.Contains("L")))
                    {
                        message.Type = "0";
                    }

                    if (!message.Area.Contains("0M") && !message.Area.Contains("0N") && !message.Area.Contains("0X") && !message.Area.Contains("0Y"))
                    {
                        repoMessage.Add(message);
                    }
                    material.DefectType = (int)packType;
                    material.IsHandleDefect = isHandlePack;
                }
            }
            await DataContext.SaveChangesAsync();
            var result = repoTr.Where(t => t.LocationId == locationId)
                .ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
            return result;
        }

        /// <summary>
        /// 盘库更改钢卷信息
        /// </summary>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult<TTrLocationMaterialReadModel>>>
            UpdateMaterial(string locationId, string coilNo, int? defectType, string user, CancellationToken cancellationToken)
        {
            var repoMaterial = DataContext.Set<TPlMaterial>();
            var repoRc = DataContext.Set<TRcMaterial>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoEvent = DataContext.Set<TRcMaterialEvent>();
            var repoMessage = DataContext.Set<TTrMessageSend>();
            var repoLog = DataContext.Set<TRcLog>();
            var repoCrane = DataContext.Set<TEqCrane>();
            var repoPl = DataContext.Set<TPlBay>();

            var tr = repoTr.Where(t => t.LocationId == locationId && t.IsEnable == 1).FirstOrDefault();
            var data = repoTr.Where(t => t.LocationId == locationId && t.IsEnable == 1).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
            if (tr == null)
            {
                return new OperationResult<TTrLocationMaterialReadModel>(false, "未找到库位信息", data);
            }

            var ownerMaterial = tr.MaterialNo;
            var materialId = tr.MaterialId;
            var lastUser = tr.UpdateUser;
            var lastTime = tr.UpdateTime;
            var lastType = tr.Type;
            var material = repoMaterial.Where(t => t.No == coilNo).FirstOrDefault();

            //清空
            if (string.IsNullOrWhiteSpace(coilNo))
            {
                CommClearLocMat(tr);
                tr.Type = (int)MaterialStatusTypes.None;
                tr.UpdateTime = DateTime.Now;
                tr.UpdateUser = "API";

                var log = new TRcLog
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    Source = "API",
                    WarningLevel = "INFO",
                    Message = $"删除库位信息{tr.LocationName},last11:{lastUser}/{lastTime}/{lastType}"
                };
                repoLog.Add(log);

                if (!string.IsNullOrEmpty(ownerMaterial))
                {
                    var record = new TRcMaterialEvent
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        MaterialId = materialId,
                        Dt = DateTime.Now,
                        MaterialNo = ownerMaterial,
                        OperationType = "人工",
                        ContentType = "盘库",
                        MaterialNoOld = "",
                        FromLocationName = tr.LocationName,
                        ToLocationName = "",
                        Description = $"原钢卷号{ownerMaterial} ，操作员：{user}扫描修改卷号",
                        FromPosition = "",
                        ToPosition = "",
                        Result = "成功"
                    };
                    repoEvent.Add(record);
                }



            }
            else if (tr.MaterialNo != coilNo) //修改
            {
                await SendMaterialInfo(coilNo, cancellationToken);
                if (material == null)
                {
                    material = repoMaterial.Where(t => t.No == coilNo).FirstOrDefault();
                    if (material != null)
                    {
                        CommUpdateMatToLoc(tr, material);

                        var record = new TRcMaterialEvent
                        {
                            Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                            MaterialId = material.Id,
                            Dt = DateTime.Now,
                            MaterialNo = coilNo,
                            OperationType = "",
                            ContentType = "人工添加，Mes请求",
                            MaterialNoOld = ownerMaterial,
                            FromLocationName = tr.LocationName,
                            ToLocationName = "",
                            Description = $"原钢卷号{ownerMaterial} ，操作员：{user}扫描修改卷号",
                            FromPosition = "",
                            ToPosition = "",
                            Result = "成功"
                        };
                        repoEvent.Add(record);

                        var log = new TRcLog
                        {
                            Id = IdWorkerGenerator.Instance.NextId().ToString(),
                            Dt = DateTime.Now,
                            EventNo = "1000",
                            Source = "API",
                            WarningLevel = "INFO",
                            Message = $"{tr.LocationName}库位由{ownerMaterial} 更改为{coilNo}"
                        };
                        repoLog.Add(log);
                    }
                    else
                    {
                        return new OperationResult<TTrLocationMaterialReadModel>(false, "系统不存在该卷信息，请重新输入", data);
                        ////Mes无卷信息  暂时添加No
                        //material = new TPlMaterial
                        //{
                        //    Id = DateTime.Now.ToFileTime().ToString(),
                        //    No = coilNo,
                        //    Thick = 1,
                        //    Width = 1,
                        //    Weight = 1,
                        //    MaterialLocationOwner = "未知",
                        //    IsEnable = 1,
                        //    CreateTime = DateTime.Now,
                        //    CreateUser = "API",
                        //    UpdateTime = DateTime.Now,
                        //    UpdateUser = "API",
                        //    Remark = "Mes无该卷信息，待核对"
                        //};
                        //repoPl.Add(material);

                        //CommUpdateMatToLoc(tr, material);

                        //var rcRecord = new TRcMaterialEvent
                        //{
                        //    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        //    MaterialId = material.Id,
                        //    Dt = DateTime.Now,
                        //    MaterialNo = coilNo,
                        //    OperationType = "",
                        //    ContentType = "人工添加卷号，Mes无卷信息",
                        //    MaterialNoOld = ownerMaterial,
                        //    FromLocationName = tr.LocationName,
                        //    ToLocationName = "",
                        //    Description = $"原钢卷号{ownerMaterial} ，操作员：{user}扫描修改卷号",
                        //    FromPosition = "",
                        //    ToPosition = "",
                        //    Result = "成功"
                        //};
                        //repoEvent.Add(rcRecord);
                    }
                }

                else
                {
                    string prevLocation = string.Empty;
                    var lms = repoTr.Where(t => t.MaterialId == material.Id && t.Type == 2).ToList();
                    if (lms != null && lms.Count > 0)
                    {
                        foreach (var lm in lms.ToList())
                        {
                            CommClearLocMat(lm);
                            var pl = new TPlMaterial()
                            {
                                Id = DateTime.Now.ToFileTime().ToString(),
                                No = $"Q{DateTime.Now:MMddHHmmss}({tr.LocationName})PK",
                                Thick = 0M,
                                Width = 0,
                                Weight = 0,
                                InnerDiameter = 610,
                                Diameter = 2000,
                                MaterialLocationOwner = "C3",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API",
                                Remark = ""
                            };
                            repoMaterial.Add(pl);

                            prevLocation = lm.LocationName;
                            lm.Type = (int)MaterialStatusTypes.InStock;
                            lm.MaterialId = pl.Id;
                            lm.MaterialNo = pl.No;
                            lm.Thick = 0M;
                            lm.Width = 0;
                            lm.Weight = 0;
                            lm.InnerDiameter = 610;
                            lm.Diameter = 2000;
                            lm.MaterialOwner = "C3";
                            lm.UpdateTime = DateTime.Now;
                            lm.UpdateUser = "API";

                            var l = new TRcLog
                            {
                                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                Dt = DateTime.Now,
                                EventNo = "1000",
                                Source = "API",
                                WarningLevel = "INFO",
                                Message = $"删除库位信息{lm.LocationName},last:{lm.UpdateUser}/{lm.UpdateTime}/2"
                            };
                            repoLog.Add(l);

                        }
                    }

                    //tr = Mapper.Map(material, tr);
                    CommUpdateMatToLoc(tr, material);
                    tr.Type = (int)MaterialStatusTypes.InStock;
                    tr.UpdateTime = DateTime.Now;
                    tr.UpdateUser = "API";

                    var log = new TRcLog
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        Source = "API",
                        WarningLevel = "INFO",
                        Message = $"{tr.LocationName}库位由{ownerMaterial} 更改为{coilNo}"
                    };
                    repoLog.Add(log);

                    var record = new TRcMaterialEvent
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        MaterialId = material.Id,
                        Dt = DateTime.Now,
                        MaterialNo = material.No,
                        OperationType = "人工",
                        ContentType = "人工更正卷号",
                        MaterialNoOld = ownerMaterial,
                        FromLocationName = prevLocation,
                        ToLocationName = tr.LocationName,
                        Description = $"原钢卷号{ownerMaterial} ，操作员：{user}修改卷号",
                        FromPosition = "",
                        ToPosition = "",
                        Result = "成功"
                    };
                    repoEvent.Add(record);

                    var message = new TTrMessageSend
                    {
                        MessageId = "WMBM01",
                        MaterialNo = material.No,
                        DestLocation = tr.LocationName,
                        BayCode = tr.BayCode,
                        Area = tr.BayCode + tr.AreaCode,
                        BusinessName = tr.OwnerBussinessName,
                        Floor = tr.FloorNo.ToString(),
                        Col = tr.ColNo.ToString(),
                        Row = tr.RowNo.ToString(),
                        Type = "2",
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API",
                        Operator = MesUser.GetUserName(tr.OwnerBussinessName),

                    };
                    var reqMat = repoMaterial.Where(t => t.No == coilNo).FirstOrDefault();
                    if (reqMat != null && (string.IsNullOrEmpty(reqMat.MaterialBussinessOwner) || reqMat.MaterialBussinessOwner.Contains("L")))
                    {
                        message.Type = "0";
                    }
                    if (!message.Area.Contains("0M") && !message.Area.Contains("0N") && !message.Area.Contains("0X") && !message.Area.Contains("0Y"))
                    {
                        repoMessage.Add(message);
                    }
                }
            }
            var result = repoTr.Where(t => t.LocationId == locationId)
                .ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
            if (coilNo != null && coilNo != "" && defectType != -1)
            {

                material.DefectType = defectType;
                material.UpdateUser = user;
                material.UpdateTime = DateTime.Now;
                if (defectType == 2 || defectType == 6)
                {
                    var crane = repoCrane.Where(t => t.OwnerId == tr.BayId).OrderByDescending(t => t.OrderX).FirstOrDefault();//查找中间车
                    if (tr.PointX > crane.MaxX && tr.PointX > crane.MaxXBoth) //在中间车最大范围
                    {
                        return new OperationResult<TTrLocationMaterialReadModel>(false, "超出自动行车作业范围", result);
                    }
                    var mbs = ServiceProvider.GetService<MbsProxy>();
                    var payLoad = new PackFinishState()
                    {
                        BayId = tr.BayId,
                        MaterialNo = material.No,
                        FromLocation = tr.LocationName
                    };
                    await mbs.Publish(payLoad);

                    await DataContext.SaveChangesAsync();

                    NoticeIconItem noticeIconItem = new()
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        Avatar = "",
                        Title = $"钢卷号：{ownerMaterial}，再处理卷已扫描!",
                        Datetime = DateTime.Now.ToString(),
                        Read = false,
                        Type = "Reprocess"
                    };
                    await _hubContext.Clients.All.SendAsync("UpdateMaterialState", noticeIconItem);

                    return new OperationResult<TTrLocationMaterialReadModel>(true, "成功创建入成品库计划", result);
                }
                if (defectType == 4)
                {
                    var plbay = repoPl.Where(t => t.MaterialNo == coilNo).FirstOrDefault();
                    if (plbay != null && plbay.ExecState == 0)
                    {
                        repoPl.Remove(plbay);
                    }
                }
            }
            await DataContext.SaveChangesAsync();

            return new OperationResult<TTrLocationMaterialReadModel>(true, "数据更新成功", result);
        }
        public static void CommClearLocMat(TTrLocationMaterial trLocMat)
        {
            trLocMat.BillOfLadingNo = null;
            trLocMat.ComplexDecideCode = null;
            trLocMat.Description = null;
            trLocMat.Diameter = null;
            trLocMat.HeadDirection = null;
            trLocMat.HoldCauseCode = null;
            trLocMat.HoldFlag = null;
            trLocMat.HoldRemark = null;
            trLocMat.InnerDiameter = null;
            //trLocMat.IsLoadEnable = null;
            trLocMat.IsOrdered = null;
            trLocMat.Length = null;
            trLocMat.MaterialId = null;
            trLocMat.MaterialNo = null;
            trLocMat.MatDirection = null;
            trLocMat.MatDisposeCode = null;
            trLocMat.MaterialOwner = null;
            trLocMat.MatStatus = null;
            trLocMat.MaxZ = 0;
            trLocMat.NextProcessCode = null;
            trLocMat.OrderName = null;
            trLocMat.OrderNo = null;
            trLocMat.PickState = null;
            trLocMat.TruckLoadListId = null;
            trLocMat.PrepickTransferNo = null;
            trLocMat.ProcessCode = null;
            trLocMat.ProdTime = null;
            trLocMat.ProductPackFlag = null;
            trLocMat.RelMaker = null;
            trLocMat.RelRemark = null;
            trLocMat.RelTime = null;
            trLocMat.SgSign = null;
            trLocMat.SgStd = null;
            trLocMat.SourceType = null;
            trLocMat.Status = 0;
            trLocMat.SteelGrade = null;
            trLocMat.Thick = null;
            trLocMat.Type = (int)LocationMaterialTypes.None;
            trLocMat.Weight = null;
            trLocMat.Width = null;
            trLocMat.LockMark = null;
            trLocMat.LockReason = null;
            trLocMat.IsDistributionShip = null;
            trLocMat.TrimFlag = null;
            trLocMat.ProductPackTime = null;
            trLocMat.DecideThick = null;
            trLocMat.DecideWidth = null;
            trLocMat.BundlePackageNo = null;
            trLocMat.Terminal = null;
            trLocMat.PackingTypeCode = null;
            trLocMat.PortLotNumber = null;
            trLocMat.TrnpModeCode = null;

            trLocMat.UpdateTime = DateTime.Now;
            if (string.IsNullOrEmpty(trLocMat.UpdateUser))
            {
                trLocMat.UpdateUser = "API";
            }
        }
        public static void CommUpdateMatToLoc(TTrLocationMaterial trLocMat, TPlMaterial material)
        {
            trLocMat.BillOfLadingNo = material.BillOfLadingNo;
            trLocMat.ComplexDecideCode = material.ComplexDecideCode;
            trLocMat.Description = material.Description;
            trLocMat.Diameter = material.Diameter;
            trLocMat.HeadDirection = material.HeadDirection;
            trLocMat.HoldCauseCode = material.HoldCauseCode;
            trLocMat.HoldFlag = material.HoldFlag;
            trLocMat.HoldRemark = material.HoldRemark;
            trLocMat.InnerDiameter = material.InnerDiameter;
            //trLocMat.IsLoadEnable = material.IsLoadEnable;
            trLocMat.IsOrdered = material.IsOrdered;
            trLocMat.Length = material.Length;
            trLocMat.MaterialId = material.Id;
            trLocMat.MaterialNo = material.No;
            trLocMat.MatDirection = material.MatDirection;
            trLocMat.MatDisposeCode = material.MatDisposeCode;
            trLocMat.MaterialOwner = material.MaterialLocationOwner;
            trLocMat.MatStatus = material.MatStatus;

            trLocMat.NextProcessCode = material.NextProcessCode;
            trLocMat.OrderName = material.OrderName;
            trLocMat.OrderNo = material.OrderNo;
            trLocMat.PickState = material.PickState;
            trLocMat.TruckLoadListId = material.TruckLoadListId;
            trLocMat.PrepickTransferNo = material.PrepickTransferNo;
            trLocMat.ProcessCode = material.ProcessCode;
            trLocMat.ProdTime = material.ProdTime;
            trLocMat.ProductPackFlag = material.ProductPackFlag;
            trLocMat.RelMaker = material.RelMaker;
            trLocMat.RelRemark = material.RelRemark;
            trLocMat.RelTime = material.RelTime;
            trLocMat.SgSign = material.SgSign;
            trLocMat.SgStd = material.SgStd;
            trLocMat.SourceType = material.SourceType;
            trLocMat.Status = material.Status;
            trLocMat.SteelGrade = material.SteelGrade;
            trLocMat.Thick = material.Thick;
            trLocMat.Type = (int)LocationMaterialTypes.InStock;
            trLocMat.Weight = material.Weight;
            trLocMat.Width = material.Width;
            trLocMat.CustomerCode = material.CustomerCode;
            trLocMat.CustomerName = material.CustomerName;
            trLocMat.LockMark = material.LockMark;
            trLocMat.LockReason = material.LockReason;
            trLocMat.IsDistributionShip = material.IsDistributionShip;

            //trLocMat.MaxZ = CalcMaxZ(trLocMat.BayId, trLocMat.LocationName, trLocMat.Diameter ?? 2000);
            trLocMat.TrimFlag = material.TrimFlag;
            trLocMat.ProductPackTime = material.ProductPackTime;
            trLocMat.DecideThick = material.DecideThick;
            trLocMat.DecideWidth = material.DecideWidth;
            trLocMat.BundlePackageNo = material.BundlePackageNo;
            trLocMat.Terminal = material.Terminal;
            trLocMat.PackingTypeCode = material.PackingTypeCode;
            trLocMat.PortLotNumber = material.PortLotNumber;
            trLocMat.TrnpModeCode = material.TrnpModeCode;

            trLocMat.UpdateTime = DateTime.Now;
            trLocMat.UpdateUser = "API";
        }

        /// <summary>
        /// 获取库位/钢卷mapping
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TTrLocationMaterialReadModel>>
            GetLocationMaterialByNo(string materialNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (!materialNo.IsValidValue())
            {
                return null;
            }

            predicate = predicate.And(t => t.MaterialNo == materialNo);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 获取扫描信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TTrLocationMaterialReadModel>>
            GetScanMaterial(string bayId, string materialNo, CancellationToken cancellationToken)
        {
            if (materialNo.IsValidValue())
            {
                var repoTr = DataContext.Set<TTrLocationMaterial>();
                var trLM = repoTr.Where(t => t.Type == 2 && t.MaterialNo == materialNo).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                if (trLM == null)
                {
                    var trMaterialNo = new TTrLocationMaterial();
                    trMaterialNo.MaterialNo = materialNo;

                    return Ok(trMaterialNo);
                }
                return Ok(trLM);
            }
            return Ok(null);
        }

        /// <summary>
        /// 扫码盘库更改库位信息
        /// </summary>
        [HttpPut("")]
        public async Task<ActionResult<TTrLocationMaterialReadModel>>
            UpdateScanLocation(string locationName, string plan, string coilNo, string user, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlMaterial>();
            var repoRc = DataContext.Set<TRcMaterial>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoEvent = DataContext.Set<TRcMaterialEvent>();
            var repoMessage = DataContext.Set<TTrMessageSend>();
            var rcID = DataContext.Set<TRcInventoryDetail>();
            var rcInventory = DataContext.Set<TRcInventory>();

            var trLocation = repoTr.Where(t => t.LocationName == locationName).FirstOrDefault();

            if (trLocation == null)
            {
                return null;
            }
            var ownerMaterial = trLocation.MaterialNo;
            if (string.IsNullOrWhiteSpace(coilNo))
            {
                CommClearLocMat(trLocation);//清空
            }
            else //if (trLocation.MaterialNo != coilNo)
            {
                var trMaterialNew = repoTr.Where(t => t.Type == 2 && t.MaterialNo == coilNo && t.LocationName == locationName).FirstOrDefault();
                var trMaterialOld = repoTr.Where(t => t.Type == 2 && t.MaterialNo == coilNo && t.LocationName != locationName).FirstOrDefault();
                var rcplan = rcInventory.Where(t => t.PlanNo == plan).FirstOrDefault();
                var rcdetail = rcID.Where(t => t.PlanId == rcplan.Id && t.MaterialNo == coilNo).FirstOrDefault();
                var material = repoPl.Where(t => t.No == coilNo).FirstOrDefault();

                if ((trMaterialNew != null || trMaterialOld != null) && rcdetail != null)
                {
                    //修改报表
                    rcdetail.UserLocationName = locationName;
                    rcdetail.SystemComment = "人工更正";
                    rcdetail.IsWms = 1;
                    rcdetail.UpdateTime = DateTime.Now;
                    rcdetail.UpdateUser = "API";
                    //清空原库存
                    CommClearLocMat(trMaterialOld);
                    //原库存新增虚拟卷
                    var pl = new TPlMaterial()
                    {
                        Id = DateTime.Now.ToFileTime().ToString(),
                        No = $"Q{DateTime.Now:MMddHHmmss}({trLocation.LocationName})PK",
                        Thick = 0M,
                        Width = 0,
                        Weight = 0,
                        InnerDiameter = 610,
                        Diameter = 2000,
                        MaterialLocationOwner = "C3",
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API",
                        Remark = ""
                    };
                    repoPl.Add(pl);
                    trMaterialOld.Type = (int)MaterialStatusTypes.InStock;
                    trMaterialOld.MaterialId = pl.Id;
                    trMaterialOld.MaterialNo = pl.No;
                    trMaterialOld.Thick = 0M;
                    trMaterialOld.Width = 0;
                    trMaterialOld.Weight = 0;
                    trMaterialOld.InnerDiameter = 610;
                    trMaterialOld.Diameter = 2000;
                    trMaterialOld.MaterialOwner = "C3";
                    trMaterialOld.UpdateTime = DateTime.Now;
                    trMaterialOld.UpdateUser = "API";
                }
                if (trMaterialNew == null && trMaterialOld == null && rcdetail != null)
                {
                    if (material.MaterialBussinessOwner.Contains("P5") || material.MaterialBussinessOwner.Contains("P6") || material.MaterialBussinessOwner.Contains("P8"))
                    {
                        rcdetail.UserLocationName = locationName;
                        rcdetail.SystemComment = "";
                        rcdetail.IsWms = 1;
                        rcdetail.UpdateTime = DateTime.Now;
                        rcdetail.UpdateUser = "API";
                    }
                    else if (material.MaterialBussinessOwner == null || material.MaterialBussinessOwner == "" || material.MaterialBussinessOwner.Contains("L"))
                    {
                        rcdetail.UserLocationName = locationName;
                        rcdetail.SystemComment = "新入库(人工更正)";
                        rcdetail.UpdateTime = DateTime.Now;
                        rcdetail.UpdateUser = "API";
                    }
                }
                CommUpdateMatToLoc(trLocation, material);
                if (material != null)
                {
                    await SendMaterialInfo(coilNo, cancellationToken);
                    //string prevLocation = string.Empty;
                    //var lms = repoTr.Where(t => t.MaterialId == material.Id).ToList();
                    //if (lms != null && lms.Count > 0)
                    //{
                    //    foreach (var lm in lms.ToList())
                    //    {
                    //        prevLocation = lm.LocationName;
                    //        lm.MaterialId = null;
                    //        lm.MaterialNo = null;
                    //        lm.Type = (int)MaterialStatusTypes.None;
                    //        lm.UpdateTime = DateTime.Now;
                    //        lm.UpdateUser = "API";
                    //    }
                    //}

                    //trLocation = Mapper.Map(material, trLocation);
                    //trLocation.Type = (int)MaterialStatusTypes.InStock;
                    //trLocation.UpdateTime = DateTime.Now;
                    //trLocation.UpdateUser = "API";

                    //上传MES
                    var message = new TTrMessageSend
                    {
                        MessageId = "WMBM01",
                        MaterialNo = coilNo,
                        DestLocation = trLocation.LocationName,
                        BayCode = trLocation.BayCode,
                        Area = trLocation.BayCode + trLocation.AreaCode,
                        BusinessName = trLocation.OwnerBussinessName,
                        Floor = trLocation.FloorNo.ToString(),
                        Col = trLocation.ColNo.ToString(),
                        Row = trLocation.RowNo.ToString(),
                        Type = "2",
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API",
                        Operator = MesUser.GetUserName(trLocation.OwnerBussinessName),

                    };
                    var reqMat = repoPl.Where(t => t.No == coilNo).FirstOrDefault();
                    if (reqMat != null && (string.IsNullOrEmpty(reqMat.MaterialBussinessOwner) || reqMat.MaterialBussinessOwner.Contains("L")))
                    {
                        message.Type = "0";
                    }

                    if (!message.Area.Contains("0M") && !message.Area.Contains("0N") && !message.Area.Contains("0X") && !message.Area.Contains("0Y"))
                    {
                        repoMessage.Add(message);
                    }

                    if (trMaterialOld != null)
                    {
                        var record = new TRcMaterialEvent
                        {
                            Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                            MaterialId = material.Id,
                            Dt = DateTime.Now,
                            MaterialNo = coilNo,
                            OperationType = "人工",
                            ContentType = "人工更正库位",
                            MaterialNoOld = ownerMaterial,
                            FromLocationName = trMaterialOld.LocationName,
                            ToLocationName = locationName,
                            Description = $"钢卷号:{coilNo}原库位{trMaterialOld.LocationName}，更改至新库位{locationName}，新库位的原卷号{ownerMaterial}，操作员：{user}扫描修改库位",
                            FromPosition = "",
                            ToPosition = "",
                            Result = "成功"
                        };
                        repoEvent.Add(record);
                    }
                    else
                    {
                        var record = new TRcMaterialEvent
                        {
                            Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                            MaterialId = material.Id,
                            Dt = DateTime.Now,
                            MaterialNo = coilNo,
                            OperationType = "人工",
                            ContentType = "人工更正库位",
                            MaterialNoOld = ownerMaterial,
                            ToLocationName = locationName,
                            Description = $"钢卷号{coilNo}原无库位，更改至新库位：{locationName}，新库位原卷号：{ownerMaterial}，操作员：{user}扫描修改库位",
                            FromPosition = "",
                            ToPosition = "",
                            Result = "成功"
                        };
                        repoEvent.Add(record);
                    }
                }
            }
            await DataContext.SaveChangesAsync();

            var result = repoTr.Where(t => t.LocationName == locationName)
                .ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
            return result;
        }

        /// <summary>
        /// 查询鞍座信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TTrLocationMaterialReadModel>>
            GetLocationDetail(string ownerid, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (ownerid.IsValidValue())
            {
                predicate = predicate.And(t => t.Id == ownerid);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);

            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<List<TTrLocationMaterialReadModel>>>
            GetLocation(CancellationToken cancellationToken)
        {
            var predicate = DataContext.Set<TTrLocationMaterial>();
            var list = predicate.Where(t => t.AreaCode == "01G").ToList();

            var listResult = list.Where(t => t.BayCode.Contains("25") || t.BayCode.Contains("26") || t.BayCode.Contains("27")).ToList();

            return Ok(listResult);
        }


        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetListOfStack(string stackId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (stackId.IsValidValue())
            {
                predicate = predicate.And(t => t.StackId == stackId);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 库内各区域的库存统计
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<List<AreaStatModel>>>
            GetStatOfAreas(string bayId, string department, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (bayId.IsValidValue())
            {
                if (department == "C3")

                {
                    predicate = predicate.And(x => x.BayId == bayId && (x.OwnerBussinessName == "P5" || x.OwnerBussinessName == "P6"
                                                || x.OwnerBussinessName == "P8") && x.AreaCode != "99A"
                                                && x.AreaCode != "88A" && x.AreaCode != "88B" && x.AreaCode != "88C" && x.IsEnable == 1);
                }
                else if (department == "Y8")
                {
                    if (bayId == "1510159484113915904")
                    {
                        predicate = predicate.And(x => x.BayId == bayId &&
                                                 (x.AreaCode == "0A" || x.AreaCode == "0C" || x.AreaCode == "0D") && x.IsEnable == 1);
                    }
                    else
                    {
                        predicate = predicate.And(x => x.BayId == bayId && x.OwnerBussinessName == "P4"
                                                    && x.AreaCode != "0M" && x.AreaCode != "0N" && x.AreaCode != "0X"
                                                    && x.AreaCode != "0Y" && x.AreaCode != "0Z" && x.AreaCode != "0W"
                                                    && x.AreaCode != "01G" && x.AreaCode != "P3" && x.IsEnable == 1);
                    }
                }
            }
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            var result = new List<AreaStatModel>();
            var list = listResult.Data;
            //获取所有区代码
            var areas = list.DistinctBy(x => x.AreaCode).Select(t => t.AreaCode).ToList();
            foreach (var area in areas)
            {
                //针对每个区，查询一二层的库存数量
                var areaList = list.Where(t => t.AreaCode == area).ToList();
                var areaStatModel = new AreaStatModel
                {
                    AreaCode = area,
                    LocationCount1 = areaList.Where(t => t.FloorNo == 1).Count(),
                    CoilCount1 = areaList.Where(t => t.FloorNo == 1 && t.Type == 2).Count(),
                    LocationCount2 = areaList.Where(t => t.FloorNo == 2).Count(),
                    CoilCount2 = areaList.Where(t => t.FloorNo == 2 && t.Type == 2).Count(),
                    Probability = (float)list.Where(t => t.Type == 2 && t.StorageType == 1).Count() / (float)list.Where(t => t.StorageType == 1).Count()
                };
                result.Add(areaStatModel);
            }

            return Ok(result.OrderBy(t => t.AreaCode));

        }

        /// <summary>
		/// 获取报表信息
		/// </summary>
		/// <returns></returns>
		[HttpGet("")]
        public async Task<ActionResult<List<TTrLocationMaterialReadModel>>>
            GetInventoryDetail(string planNo, CancellationToken cancellationToken)
        {
            var repoRc = DataContext.Set<TRcInventory>();
            var repoDetail = DataContext.Set<TRcInventoryDetail>();
            var predicateTr = DataContext.Set<TTrLocationMaterial>();
            List<TTrLocationMaterial> trList = new List<TTrLocationMaterial>();
            if (planNo.IsValidValue())
            {
                var model = repoRc.Where(t => t.PlanNo == planNo).FirstOrDefault();
                var detailList = repoDetail.Where(t => t.PlanId == model.Id).ToList();
                foreach (var item in detailList)
                {
                    var detail = await predicateTr.Where(t => t.MaterialNo.Contains(item.MaterialNo)).FirstOrDefaultAsync();
                    if (detail != null)
                    {
                        trList.Add(detail);
                    }
                }
            }
            return Ok(trList);
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllColumns(string bayId, string areaCode, int rowNo = 0, CancellationToken cancellationToken = default)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (areaCode.IsValidValue())
            {
                if (rowNo > 0)
                {
                    predicate = predicate.And(x => x.BayId == bayId && x.AreaCode == areaCode && x.RowNo == rowNo && x.IsEnable == 1);
                }
                else
                {
                    predicate = predicate.And(x => x.BayId == bayId && x.AreaCode == areaCode && x.IsEnable == 1);
                }
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 获取行信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllRows(string bayId, string areaCode, int rowNo, int storageType, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(x => x.BayId == bayId && x.AreaCode == areaCode &&
                    x.RowNo == rowNo && x.StorageType == storageType);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 客户端包装线跟踪
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetChainQuery([FromQuery] PageParam pageParam, string key, string areaId, CancellationToken cancellationToken)
        {
            var tSc = ExpressionBuilder.True<TScDictionary>();
            var tTr = DataContext.Set<TTrLocationMaterial>();
            var tTrs = ExpressionBuilder.True<TTrLocationMaterial>();
            var query = tTr.AsNoTracking();
            var str = key.Substring(0, 2);
            if (areaId != null)
            {
                tTrs = tTrs.And(t => t.BayCode == str && t.AreaId == areaId);
            }
            tTrs = tTrs.And(t => t.BayCode == str);
            if (key.Substring(key.Length - 1, 1) == "1")
            {
                tTrs = tTrs.And(t => t.AreaCode.Contains("0X") || t.AreaCode.Contains("0M"));
            }
            else
            {
                tTrs = tTrs.And(t => t.AreaCode.Contains("0Y") || t.AreaCode.Contains("0N"));
            }
            //query = query.Where(tTrs).OrderBy(t => t.AreaId).ThenBy(t => t.ColNo);
            query = query.Where(tTrs).OrderByDescending(t => t.AreaCode).ThenBy(t => t.ColNo);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 客户端删除包装线物料号
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<int>>
            DeleteChainCoil(string bayCode, string areaCode, int colNo, string materialNo)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();
            if (bayCode.IsValidValue())
            {
                var payLoad = new CplMaterialLocUpdate()
                {
                    BayCode = bayCode,
                    AreaCode = areaCode,
                    ColNo = ((byte)colNo),
                    LoadMatType = 2,//退料
                    MaterialNo = materialNo
                };
                await mbs.Publish(payLoad);
                return Ok(true);
            }
            return Ok(false);
        }

        /// <summary>
        /// 客户端添加包装线物料号
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<int>>
            AddChainCoil(string bayCode, string areaCode, int colNo, string materialNo)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();
            if (bayCode.IsValidValue())
            {
                var payLoad = new CplMaterialLocUpdate()
                {
                    BayCode = bayCode,
                    AreaCode = areaCode,
                    ColNo = ((byte)colNo),
                    LoadMatType = 1,//上料
                    MaterialNo = materialNo
                };
                await mbs.Publish(payLoad);

                var wmbm16 = new TeleWMBM16()
                {
                    Payload = new CoilInfoUpdate() { CoilNo = materialNo }
                };
                await mbs.Publish(wmbm16);

                return Ok(true);
            }
            return Ok(false);
        }

        [HttpGet("")]
        public async Task<ActionResult<OperationResult>> IsExist(string material, string newLocation)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var trlm = repoTr.Where(t => t.MaterialNo == material && t.Type == 2).FirstOrDefault();
            if (trlm != null)
            {
                var bay = trlm.LocationName[..2];
                var qu = trlm.LocationName.Substring(3, 1);
                var oldlie = trlm.LocationName.Substring(6, 2);
                var newlie = newLocation.Substring(6, 2);
                var desctiption = $"该卷号已经在{trlm.LocationName},确认更新至{newlie}号位吗？";
                if ((trlm.LocationName.Contains("X") || trlm.LocationName.Contains("Y")))
                {
                    desctiption = $"{material}已经在步进梁{oldlie}号位，确认更新至{newlie}号位吗？";
                    return new OperationResult(true, desctiption);
                }
                else if (trlm != null && (trlm.LocationName.Contains("M") || trlm.LocationName.Contains("N")))
                {
                    desctiption = $"{material}已经在缓存区{oldlie}号位，确认更新至{newlie}号位吗？";
                    return new OperationResult(true, desctiption);
                }
                return new OperationResult(true, desctiption);
            }
            else
            {
                return new OperationResult(false, $"");
            }
        }

        /// <summary>
        /// 手持机上料
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> AddHoldChainCoil(string locationId, string materialNo, string userName, CancellationToken cancellationToken)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoEvent = DataContext.Set<TRcMaterialEvent>();
            var repoPl = DataContext.Set<TPlMaterial>();
            var logs = DataContext.Set<TRcLog>();
            if (locationId.IsValidValue())
            {
                var tr = repoTr.Where(t => t.LocationId == locationId).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                var oldLocations = repoTr.Where(t => t.MaterialNo == materialNo && t.LocationName != tr.LocationName && t.Type == 2).ToList();
                var plMaterial = repoPl.Where(t => t.No == materialNo).FirstOrDefault();
                if (tr == null)
                {
                    return new OperationResult(false, "库位为null");
                }
                if (plMaterial == null)
                {
                    await SendMaterialInfo(materialNo, cancellationToken);
                    plMaterial = repoPl.Where(t => t.No == materialNo).FirstOrDefault();
                    if (plMaterial == null)
                    {
                        return new OperationResult(false, "WMS卷号不存在");
                    }
                }
                await SendMaterialInfo(materialNo, cancellationToken);
                var mbs = ServiceProvider.GetService<MbsProxy>();
                var payLoad = new CplMaterialLocUpdate()
                {
                    BayCode = tr.BayCode,
                    AreaCode = tr.AreaCode,
                    ColNo = ((byte)tr.ColNo),
                    LoadMatType = 1,//上料
                    MaterialNo = materialNo
                };
                await mbs.Publish(payLoad);

                var wmbm16 = new TeleWMBM16()
                {
                    Payload = new CoilInfoUpdate() { CoilNo = materialNo }
                };
                await mbs.Publish(wmbm16);

                var rcRecord = new TRcMaterialEvent
                {
                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                    MaterialId = plMaterial.Id,
                    Dt = DateTime.Now,
                    MaterialNo = materialNo,
                    OperationType = "人工",
                    ContentType = "人工更正上料",
                    FromLocationName = "",
                    ToLocationName = tr.LocationName,
                    Description = $"人工修改库位卷号原卷号：{tr.MaterialNo}，操作员：{userName}",
                    FromPosition = "",
                    ToPosition = "",
                    Result = "成功"
                };
                if (oldLocations.Count > 0)
                {
                    rcRecord.FromLocationName = oldLocations[0].LocationName;
                }
                repoEvent.Add(rcRecord);

                var log = new TRcLog
                {
                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    WarningLevel = "INFO",
                    Message = $"手持机{userName}用户{materialNo}-{tr.LocationName}上料",
                    Source = "API"
                };
                logs.Add(log);

                //原库位增加虚拟卷号
                if (oldLocations != null && oldLocations.Count > 0)
                {
                    foreach (var oldLocation in oldLocations)
                    {
                        if (oldLocation.LocationName.Contains("X") || oldLocation.LocationName.Contains("Y") || oldLocation.LocationName.Contains("M") || oldLocation.LocationName.Contains("N") || oldLocation.LocationName.Contains("Z"))
                        {
                            var payLoad1 = new CplMaterialLocUpdate()
                            {
                                BayCode = oldLocation.BayCode,
                                AreaCode = oldLocation.AreaCode,
                                ColNo = ((byte)oldLocation.ColNo),
                                LoadMatType = 1,//上料
                                MaterialNo = $"Q{DateTime.Now:MMddHHmmss}({tr.LocationName})SL",
                            };
                            await mbs.Publish(payLoad1);
                        }
                        else
                        {
                            CommClearLocMat(oldLocation);
                            var pl = new TPlMaterial()
                            {
                                Id = DateTime.Now.ToFileTime().ToString(),
                                No = $"Q{DateTime.Now:MMddHHmmss}({tr.LocationName})SL",
                                Thick = 0M,
                                Width = 0,
                                Weight = 0,
                                InnerDiameter = 610,
                                Diameter = 2000,
                                MaterialLocationOwner = "C3",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API",
                                Remark = ""
                            };
                            repoPl.Add(pl);
                            oldLocation.Type = (int)MaterialStatusTypes.InStock;
                            oldLocation.Id = pl.Id;
                            oldLocation.MaterialNo = pl.No;
                            oldLocation.InnerDiameter = 610;
                            oldLocation.Diameter = 2000;
                            oldLocation.MaterialOwner = "C3";
                            oldLocation.UpdateTime = DateTime.Now;
                            oldLocation.UpdateUser = "API";
                        }
                    }
                }
                var count = await DataContext.SaveChangesAsync();
                if (count > 0)
                {
                    return new OperationResult(true, "卷号已更正");
                }
            }
            return new OperationResult(false, "更改失败");
        }

        /// <summary>
        /// 手持机下料
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> DeleteHoldChainCoil(string locationId, string userName)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoEvent = DataContext.Set<TRcMaterialEvent>();
            var logs = DataContext.Set<TRcLog>();
            if (locationId.IsValidValue())
            {
                var tr = repoTr.Where(t => t.LocationId == locationId).FirstOrDefault();
                var mbs = ServiceProvider.GetService<MbsProxy>();
                if (tr.MaterialId == null)
                {
                    return new OperationResult(true, $"");
                }
                var payLoad = new CplMaterialLocUpdate()
                {
                    BayCode = tr.BayCode,
                    AreaCode = tr.AreaCode,
                    ColNo = ((byte)tr.ColNo),
                    LoadMatType = 2,//退料
                    MaterialNo = tr.MaterialNo
                };
                await mbs.Publish(payLoad);

                var rcRecord = new TRcMaterialEvent
                {
                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                    MaterialId = tr.MaterialId,
                    Dt = DateTime.Now,
                    MaterialNo = tr.MaterialNo,
                    OperationType = "人工",
                    ContentType = "人工更正下料",
                    FromLocationName = tr.LocationName,
                    ToLocationName = "",
                    Description = $"人工修改库位，操作员：{userName}",
                    FromPosition = "",
                    ToPosition = "",
                    Result = "成功"
                };
                repoEvent.Add(rcRecord);

                var log = new TRcLog
                {
                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    WarningLevel = "INFO",
                    Message = $"手持机{userName}用户{tr.MaterialNo}-{tr.LocationName}下料",
                    Source = "API"
                };
                logs.Add(log);
                repoEvent.Add(rcRecord);
                await DataContext.SaveChangesAsync();
                return new OperationResult(true, "卷号已更正（下料）");
            }
            return new OperationResult(true, "卷号更改失败（下料）");
        }

        /// <summary>
        /// 库存数据筛选
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetPageQuery([FromQuery] PageParam pageParam, [FromQuery] int[] type, [FromQuery] string[] bayId, [FromQuery] string[] areaId, [FromQuery] string[] stackId, [FromQuery] int[] storageType, string materialNo, [FromQuery] int[] isEnable, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (type.Length > 0 && type != null)
            {
                predicate = predicate.And(x => type.Contains(x.Type));
            }
            if (bayId.Length > 0 && bayId != null)
            {
                predicate = predicate.And(x => bayId.Contains(x.BayId));
            }

            if (areaId.Length > 0 && areaId != null)
            {
                predicate = predicate.And(x => areaId.Contains(x.AreaId));
            }
            if (stackId.Length > 0 && stackId != null)
            {
                predicate = predicate.And(x => stackId.Contains(x.StackId));
            }
            if (storageType.Length > 0 && storageType != null)
            {
                predicate = predicate.And(x => storageType.Contains(x.StorageType));
            }
            if (materialNo != null)
            {
                predicate = predicate.And(x => materialNo.Contains(x.MaterialNo));
            }
            if (isEnable.Length > 0 && isEnable != null)
            {
                predicate = predicate.And(x => isEnable.Contains(x.IsEnable));
            }
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 手持端包装线跟踪数据
        /// </summary>
        /// <returns></returns> 
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetChainList(string key, CancellationToken cancellationToken)
        {
            var tSc = ExpressionBuilder.True<TScDictionary>();
            var tTr = ExpressionBuilder.True<TTrLocationMaterial>();
            var str = key.Substring(0, 2);
            tTr = tTr.And(t => t.BayCode == str);
            if (key.Substring(key.Length - 1, 1) == "1")
            {
                tTr = tTr.And(t => t.AreaCode.Contains("0X") || t.AreaCode.Contains("0M"));
            }
            else if (key.Substring(key.Length - 1, 1) == "2")
            {
                tTr = tTr.And(t => t.AreaCode.Contains("0Y") || t.AreaCode.Contains("0N"));
            }
            else
            {
                tTr = tTr.And(t => t.AreaCode.Contains("0Y") || t.AreaCode.Contains("0N") || t.AreaCode.Contains("0X") || t.AreaCode.Contains("0M"));
            }
            var query = GetQueryOrderByIdAsc(tTr);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 客户端查询钢卷
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllMaterials(string materialNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(x => x.MaterialNo == materialNo);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryPageModel(query);
            return Ok(listResult);
        }

        /// <summary>
        /// 手持机查询卷号
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetHoldAllMaterials(string materialNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(x => x.MaterialNo.Contains(materialNo));
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 查询库位
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllLocation(string locationName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (locationName.IsValidValue())
            {
                predicate = predicate.And(x => x.LocationName == locationName);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// WPF获取库位
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TTrLocationMaterialReadModel>>
            GetLocationName(string locationName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (!locationName.IsValidValue())
            {
                return null;
            }

            predicate = predicate.And(t => t.LocationName == locationName);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 发送请求卷号信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<ItemResult<TTrLocationMaterialReadModel>>>
            SendMaterialInfo(string materialNo, CancellationToken cancellationToken)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();
            var item = new ItemResult<TTrLocationMaterialReadModel>();
            if (materialNo.IsValidValue())
            {
                var info = new CoilInfoRequest();
                info.CoilNo = materialNo;
                var payLoad = new TeleWMBM02
                {
                    Payload = info
                };
                await mbs.Publish(payLoad);
                item.Success = true;
                item.Message = "钢卷信息请求已发出";
                return item;
            }
            item.Success = false;
            item.Message = "请输入钢卷信息";
            return item;
        }

        /// <summary>
        /// 获取行信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllAreaRows(string bayId, int storeageType, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(x => x.BayId == bayId && x.StorageType == storeageType);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }


        /// <summary>
        /// 获取电瓶车钢卷信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllTrolleybusCoils(string bayName, int storageType, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();

            if (bayName.IsValidValue())
            {
                predicate = predicate.And(t => bayName.Contains(t.BayCode) && t.StorageType == storageType);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 获取过跨车钢卷信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllCrossCarCoils(string bayName, int storageType, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();

            if (bayName.IsValidValue())
            {
                predicate = predicate.And(t => bayName.Contains(t.BayCode) && t.StorageType == storageType);
            }
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 获取汽车移库钢卷信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetAllTruckTransferCoils(string houseId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            //predicate = predicate.And(t => t.MaterialTPlMaterial.StockType == 3 &&
            //                                    (t.MaterialTPlMaterial.PickState == 0 || t.MaterialTPlMaterial.PickState == null) &&
            //                                    t.BayId == houseId);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 更改吊运任务冻结状态
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<int>> UpdateTaskState
            (string bayId, string materialNo, CancellationToken cancellationToken)
        {
            var predicate = DataContext.Set<TTrLocationMaterial>();
            if (materialNo.IsValidValue())
            {
                var result = predicate.Where(x => x.BayId == bayId && x.MaterialNo == materialNo && x.StorageType == 1).FirstOrDefault();
                if (result != null)
                {
                    if (result.IsEnable == 1)
                    {
                        result.IsEnable = 0;
                    }
                    else
                    {
                        result.IsEnable = 1;
                    }
                }
                var count = await DataContext.SaveChangesAsync();
                return count;
            }
            return null;
        }
        /// <summary>
        /// 车载终端获取跨库位信息用于生成库位图
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>>
            GetLocMatList(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.BayId == bayId);
            }
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        private async Task<(decimal, decimal)> GetCraneRange(string bayId)
        {
            var eqs = DataContext.Set<TEqCrane>();
            var query = eqs.AsNoTracking();
            var predicate = ExpressionBuilder.True<TEqCrane>();
            if (bayId == "1510090554074730496")
            {
                predicate = predicate.And(t => t.OrderX != 4);
            }
            else
            {
                predicate = predicate.And(t => t.OrderX != 3);
            }
            var eqsList = await query.Where(t => t.OwnerId == bayId).Where(predicate).ToListAsync();

            List<decimal> minX = new();
            List<decimal> maxX = new();

            foreach (var item in eqsList)
            {
                minX.Add(item.MinX);
                maxX.Add(item.MaxX);
            }
            minX.Sort();
            maxX.Sort();
            maxX.Reverse();
            return (minX[0], maxX[0]);
        }

        private async Task<(decimal, decimal)> GetBayIdByAreaID(string areaId)
        {
            var whAreas = DataContext.Set<TWhArea>();
            var whBays = DataContext.Set<TWhBay>();
            var areaOne = await whAreas.AsNoTracking().Where(t => t.Id == areaId).FirstOrDefaultAsync();
            if (areaOne != null)
            {
                var baysOne = await whBays.AsNoTracking().Where(t => t.Id == areaOne.OwnerId).FirstOrDefaultAsync();
                if (baysOne != null)
                {
                    return await GetCraneRange(baysOne.Id);
                }
            }
            return (0M, 0M);

        }



        /// <summary>
        /// 库位统计查询--1,以跨为单位
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<LocationPercent>>> GetBayPercent([FromQuery] PageParam pageParam, CancellationToken cancellationToken)
        {
            var whBays = DataContext.Set<TWhBay>();
            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var baylist = await whBays.AsNoTracking().Where(t => t.IsEnable == 1).ToListAsync();
            var listPer = new List<LocationPercent>();
            var Total = baylist.Count;
            for (int i = 0; i < baylist.Count; i++)
            {
                var (minX, maxX) = await GetCraneRange(baylist[i].Id);
                var query = trLocationMaterials.AsNoTracking().Where(t => t.IsEnable == 1 && t.BayId == baylist[i].Id && t.PointX > minX && t.PointX < maxX && t.OwnerBussinessName != "P4" && t.IsVirtual == 0);

                //一层库位总数
                var oneLoSum = query.Where(t => t.FloorNo == 1).Count();

                //一层钢卷总数
                var oneNoSum = query.Where(t => t.FloorNo == 1 && t.MaterialNo != "" && t.MaterialNo != null).Count();

                //二层库位总数
                var twoLoSum = query.Where(t => t.FloorNo == 2).Count();

                //二层钢卷总数
                var twoNoSum = query.Where(t => t.FloorNo == 2 && t.MaterialNo != "" && t.MaterialNo != null).Count();

                // 一层使用率、
                var oneFloorPer = Math.Round(oneNoSum / (double)oneLoSum, 4) * 100;

                // 二层使用率、
                var twoFloorPer = Math.Round(twoNoSum / (double)twoLoSum, 4) * 100;

                // 总体使用率
                var allFloorPer = Math.Round((oneNoSum + twoNoSum) / (double)(oneLoSum + twoLoSum), 4) * 100;

                var LocationPercent = new LocationPercent
                {
                    id = baylist[i].Id,
                    name = baylist[i].Name,
                    oneLoSum = oneLoSum,
                    oneNoSum = oneNoSum,
                    twoLoSum = twoLoSum,
                    twoNoSum = twoNoSum,
                    oneFloorPer = oneFloorPer,
                    twoFloorPer = twoFloorPer,
                    allFloorPer = allFloorPer
                };
                listPer.Add(LocationPercent);
            }

            var result = new PageResult<LocationPercent>
            {
                Success = true,
                Data = listPer,
                Message = "查询成功！",
                Total = Total
            };
            return result;
        }


        /// <summary>
        /// 库位统计查询--2,以垛为单位
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<LocationPercent>>> GetStackPercent([FromQuery] PageParam pageParam, [FromQuery] string[] id, CancellationToken cancellationToken)
        {
            var whStacks = DataContext.Set<TWhStack>();
            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var queryStr = whStacks.AsNoTracking().Where(t => t.IsEnable == 1);
            if (id != null && id.Length > 0)
            {
                queryStr = queryStr.Where(t => id.Contains(t.Id));
            }
            queryStr = queryStr.OrderBy(t => t.Id);
            var Total = queryStr.Count();
            queryStr = queryStr.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize);
            var stacklist = await queryStr.ToListAsync();
            var listPer = new List<LocationPercent>();
            for (int i = 0; i < stacklist.Count; i++)
            {
                var (minX, maxX) = await GetBayIdByAreaID(stacklist[i].OwnerId);
                var query = trLocationMaterials.AsNoTracking().Where(t => t.IsEnable == 1 && t.StackId == stacklist[i].Id && t.PointX > minX && t.PointX < maxX);

                //一层库位总数
                var oneLoSum = query.Where(t => t.FloorNo == 1).Count();

                //一层钢卷总数
                var oneNoSum = query.Where(t => t.FloorNo == 1 && t.MaterialNo != "" && t.MaterialNo != null).Count();

                //二层库位总数
                var twoLoSum = query.Where(t => t.FloorNo == 2).Count();

                //二层钢卷总数
                var twoNoSum = query.Where(t => t.FloorNo == 2 && t.MaterialNo != "" && t.MaterialNo != null).Count();

                // 一层使用率、
                var oneFloorPer = Math.Round(oneNoSum / (double)oneLoSum, 4) * 100;

                // 二层使用率、
                var twoFloorPer = Math.Round(twoNoSum / (double)twoLoSum, 4) * 100;

                // 总体使用率
                var allFloorPer = Math.Round((oneNoSum + twoNoSum) / (double)(oneLoSum + twoLoSum), 4) * 100;

                var LocationPercent = new LocationPercent
                {
                    id = stacklist[i].Id,
                    name = stacklist[i].Name,
                    oneLoSum = oneLoSum,
                    oneNoSum = oneNoSum,
                    twoLoSum = twoLoSum,
                    twoNoSum = twoNoSum,
                    oneFloorPer = oneFloorPer,
                    twoFloorPer = twoFloorPer,
                    allFloorPer = allFloorPer
                };
                listPer.Add(LocationPercent);
            }

            var result = new PageResult<LocationPercent>
            {
                Success = true,
                Data = listPer,
                Message = "查询成功！",
                Total = Total
            };
            return result;
        }

        /// <summary>
        /// 当鞍座禁用时，更新stack启用状态
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<OperationResult>> UpdateStackIsEnable(CancellationToken cancellationToken)
        {

            var whStacks = DataContext.Set<TWhStack>();
            var queryStr = whStacks.OrderBy(t => t.Id);
            var stacklist = queryStr.ToList();

            for (int i = 0; i < stacklist.Count; i++)
            {
                var trLocationMaterials = DataContext.Set<TWhLocation>();
                var query = trLocationMaterials.Where(t => t.IsEnable == 1 && t.OwnerId == stacklist[i].Id);
                var oneFloorSum = query.Count();
                if (oneFloorSum == 0)
                {

                    var repoTr = DataContext.Set<TWhStack>().FirstOrDefault(t => t.Id == stacklist[i].Id);
                    repoTr.IsEnable = 0;
                    await DataContext.SaveChangesAsync(cancellationToken);
                }
            }
            return new OperationResult(true, "更新成功！");
        }

        /// <summary>
        /// 生成零点库存表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> CreateLDMatReportExcel(CancellationToken cancellationToken)
        {
            var ldmatList = new List<LDMat>();
            var ldmats = new LDMat()
            {
                BayCode = "16",
                Kb = "P5",
                Hy = GetHy("16").ToString(),
                Lbnm = GetLbnm("16").ToString(),
                Lbwm = GetLbwm("16").ToString(),
                Qy = GetQy("16").ToString(),
                Sqly = GetSqly("16").ToString(),
                Wd = GetWd("16").ToString(),
                Yzwd = GetYwz("16").ToString()
            };
            ldmatList.Add(ldmats);
            ldmatList.Add(ldmats);

            var resultList = new PageResult<LDMat>
            {
                Data = ldmatList,
                Success = true,
            };
            await Task.CompletedTask;

            return FileResult("零点库存结构", resultList);
        }
        private FileStreamResult FileResult(string reportname, object list)
        {
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportname}.xlsx", list);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportname}.xlsx"
            };
        }

        /// <summary>
        /// 火运
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetHy(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode) && t.MatDirection.Equals("C1"));//TODO  流向字段 ==C1     MAT_DIRECTION
            query = query.Where(predicate);
            var count = query.Count();
            return count;
        }

        /// <summary>
        /// 岚北内贸
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetLbnm(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode) && t.MatDirection.Equals("U127") && t.OrderNo.StartsWith("D"));//TODO  流向字段 ==U127  订单号D开头
            query = query.Where(predicate);
            return query.Count();
        }

        /// <summary>
        /// 岚北外贸
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetLbwm(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode) && t.MatDirection.Equals("U127") && t.OrderNo.StartsWith("E"));//TODO  流向字段 ==U127  订单号E开头,他们的库存表订单号和合同号 不是一个
            query = query.Where(predicate);
            return query.Count();
        }

        /// <summary>
        /// 汽运
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetQy(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode) && !string.IsNullOrEmpty(t.OrderNo) && string.IsNullOrEmpty(t.MatDirection));//TODO  
            query = query.Where(predicate);
            return query.Count();
        }

        /// <summary>
        /// 水汽联运    数据不对
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetSqly(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode));//TODO   他们的库存表有这个字段
            query = query.Where(predicate);
            return query.Count();
        }

        /// <summary>
        /// 无单
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetWd(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode) && string.IsNullOrEmpty(t.OrderNo));//TODO   他们的库存表有 是否有单 字段
            query = query.Where(predicate);
            return query.Count();
        }

        /// <summary>
        /// 有主无单
        /// </summary>
        /// <param name="baycode"></param>
        /// <returns></returns>
        private int GetYwz(string baycode)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.BayCode.Equals(baycode) && t.IsOrdered.Equals(1) && string.IsNullOrEmpty(t.OrderNo));//TODO   有无主  他们的库存表有 是否有单 字段
            query = query.Where(predicate);
            return query.Count();
        }


        /// <summary>
        /// 生成零点订单表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> CreateLDOrderReportExcel(CancellationToken cancellationToken)
        {
            var lDOrdersList = new List<LDOrder>();
            var lDOrder = new LDOrder()
            {
                Bj = GetLbnmOrder("bj").ToString(), //根据钢卷类型
                Dx = GetLbnmOrder("Dx").ToString(),
                Hj = GetLbnmOrder("Hj").ToString(),
                Gb = GetLbnmOrder("Gb").ToString(),
                Zdj = GetLbnmOrder("Zdj").ToString(),
                Zdmt = GetLbnmOrder("Zdmt").ToString(),
                Zj = GetLbnmOrder("Zj").ToString(),
                Zldzj = GetLbnmOrder("Zldzj").ToString(),
                Djsz = GetLbnmOrder("Djsz").ToString()
            };
            lDOrdersList.Add(lDOrder);

            var resultList = new PageResult<LDOrder>
            {
                Data = lDOrdersList,
                Success = true,
            };
            await Task.CompletedTask;
            return FileResult("零点订单结构", resultList);
        }

        /// <summary>
        /// 海运，岚北内贸,
        /// </summary>
        /// <returns></returns>
        private int GetLbnmOrder(string gjlx)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.MatDirection.Equals("U127") && t.OrderNo.StartsWith("D"));//TODO  流向字段 ==U127  订单号D开头
            query = query.Where(predicate);
            return query.Count();
        }

        /// <summary>
        /// 外贸海运， 岚北外贸
        /// </summary>
        /// <returns></returns>
        private int GetLbwmOrder(string gjlx)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.Type.Equals(2) && t.MatDirection.Equals("U127") && t.OrderNo.StartsWith("E"));//TODO  流向字段 ==U127  订单号E开头,他们的库存表订单号和合同号 不是一个
            query = query.Where(predicate);
            return query.Count();
        }


        /// <summary>
        /// 获取库位
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetListOfLocationRange(string areaId, string stackId, string stackId2, string colNo, string colNo2, int type, [FromQuery] string[] locationNames, CancellationToken cancellationToken)
        {
            var stackNo = await GetStackNo(stackId);
            var stackNo2 = await GetStackNo(stackId2);

            var locationcolNo = await GetLocationColNo(colNo);
            var locationcolNo2 = await GetLocationColNo(colNo2);

            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (areaId.IsValidValue())
            {
                predicate = predicate.And(t => t.AreaId == areaId);
            }
            if (locationNames.Length > 0 && locationNames != null)
            {
                predicate = predicate.And(t => !locationNames.Contains(t.LocationName));
            }

            predicate = predicate.And(t => t.IsEnable == 1 && t.Type == type);
            predicate = predicate.And(t => t.RowNo >= stackNo && t.RowNo <= stackNo2);
            predicate = predicate.And(t => t.ColNo >= locationcolNo && t.ColNo <= locationcolNo2);
            var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.ColNo);
            if (type == 2)
            {
                query = query.OrderByDescending(t => t.FloorNo);
            }
            if (type == 0)
            {
                query = query.OrderBy(t => t.FloorNo);
            }
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }



        /// <summary>
        /// 获取同订单目标库位
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetListOfLocationRangeOrder(string areaId, string stackId, string stackId2, string colNo, string colNo2, int type, string loadLocationName, CancellationToken cancellationToken)
        {
            string orderNo = string.Empty;
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var locationMaterial = await dbSet.AsNoTracking().Where(t => t.LocationName == loadLocationName).FirstOrDefaultAsync();
            if (locationMaterial != null)
            {
                orderNo = locationMaterial.OrderNo;

                var stackNo = await GetStackNo(stackId);
                var stackNo2 = await GetStackNo(stackId2);

                var locationcolNo = await GetLocationColNo(colNo);
                var locationcolNo2 = await GetLocationColNo(colNo2);

                var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
                if (areaId.IsValidValue())
                {
                    predicate = predicate.And(t => t.AreaId == areaId);
                }
                predicate = predicate.And(t => t.LocationName != loadLocationName);
                predicate = predicate.And(t => t.OrderNo == orderNo);
                predicate = predicate.And(t => t.IsEnable == 1 && t.Type == type);
                predicate = predicate.And(t => t.RowNo >= stackNo && t.RowNo <= stackNo2);
                predicate = predicate.And(t => t.ColNo >= locationcolNo && t.ColNo <= locationcolNo2);
                var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.ColNo);
                if (type == 2)
                {
                    query = query.OrderByDescending(t => t.FloorNo);
                }
                if (type == 0)
                {
                    query = query.OrderBy(t => t.FloorNo);
                }
                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }
            return new PageResult<TTrLocationMaterialReadModel>
            {
                Data = null,
                Success = true,
                Total = 0
            };
        }

        /// <summary>
        /// 查询行号
        /// </summary>
        /// <returns></returns>
        private async Task<int> GetStackNo(string stackId)
        {
            var dbSet = DataContext.Set<TWhStack>();
            var firstStack = await dbSet.AsNoTracking().Where(t => t.Id == stackId).FirstOrDefaultAsync();
            if (firstStack != null)
            {
                return firstStack.StackNo;
            }
            return 0;
        }

        /// <summary>
        /// 查询列号
        /// </summary>
        /// <returns></returns>
        private async Task<int> GetLocationColNo(string locationId)
        {
            var dbSet = DataContext.Set<TWhLocation>();
            var firstStack = await dbSet.AsNoTracking().Where(t => t.Id == locationId).FirstOrDefaultAsync();
            if (firstStack != null)
            {
                return firstStack.ColNo;
            }
            return 0;
        }

        /// <summary>
        /// 查询该库位是否在库
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<bool> GetLocationType2(string locationName)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var firstStack = await dbSet.AsNoTracking().Where(t => t.LocationName == locationName && t.IsEnable == 1 && t.Type == 2).FirstOrDefaultAsync();
            return firstStack != null;
        }

        /// <summary>
        /// 判断选择的目标库位，，是否能大压小
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<bool> GetEndLocationYesBool(string startlocationName, string endLocationName)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var location = await dbSet.AsNoTracking().Where(t => t.LocationName == endLocationName && t.IsEnable == 1).FirstOrDefaultAsync();
            //二层 2602A08 06 2       2602A08 06 1     2602A08 07 1
            if (location != null)
            {
                var bayId = location.BayId;
                var areaCode = location.AreaCode;
                var rowNo = location.RowNo;
                var leftColNo = location.ColNo;
                var rightColNo = location.ColNo + 1;

                var left = dbSet.AsNoTracking().FirstOrDefault(t => t.BayId == bayId &&
                                                           t.AreaCode == areaCode &&
                                                           t.RowNo == rowNo &&
                                                           t.ColNo == leftColNo &&
                                                           t.Type == 2 &&
                                                           t.IsEnable == 1 &&
                                                           t.FloorNo == 1);
                var right = dbSet.AsNoTracking().FirstOrDefault(t => t.BayId == bayId &&
                                                           t.AreaCode == areaCode &&
                                                           t.RowNo == rowNo &&
                                                           t.ColNo == rightColNo &&
                                                           t.Type == 2 &&
                                                           t.IsEnable == 1 &&
                                                           t.FloorNo == 1);
                if (left != null && right != null)
                {
                    var startlocation = await dbSet.AsNoTracking().Where(t => t.LocationName == startlocationName && t.IsEnable == 1 && t.Type == 2).FirstOrDefaultAsync();
                    if (startlocation != null)
                    {
                        var locationWig = location.Weight;
                        var leftlocationWig = left.Weight;
                        var rightlocationWig = right.Weight;
                        if (locationWig > leftlocationWig || locationWig > rightlocationWig)
                        {
                            return false;
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 判断起始库位一层的上面是否有卷，是否允许吊
        /// </summary>
        [HttpGet]
        public async Task<bool> GetStartFirstColNoSecondBool(string locationName)
        {//1601A02041
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var location = await dbSet.AsNoTracking().Where(t => t.LocationName == locationName && t.IsEnable == 1 && t.Type == 2).FirstOrDefaultAsync();
            //一层 1601A02041        1601A 02 03 2   1601A 02 04 2
            if (location != null)
            {
                var bayId = location.BayId;
                var areaCode = location.AreaCode;
                var rowNo = location.RowNo;
                var leftColNo = location.ColNo - 1;
                var rightColNo = location.ColNo;

                var left = dbSet.AsNoTracking().FirstOrDefault(t => t.BayId == bayId &&
                                                           t.AreaCode == areaCode &&
                                                           t.RowNo == rowNo &&
                                                           t.ColNo == leftColNo &&
                                                           t.Type == 2 &&
                                                           t.IsEnable == 1 &&
                                                           t.FloorNo == 2);
                var right = dbSet.AsNoTracking().FirstOrDefault(t => t.BayId == bayId &&
                                                           t.AreaCode == areaCode &&
                                                           t.RowNo == rowNo &&
                                                           t.ColNo == rightColNo &&
                                                           t.Type == 2 &&
                                                           t.IsEnable == 1 &&
                                                           t.FloorNo == 2);
                if (left != null || right != null)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断目标库位二层的下面是否有卷，是否允许放
        /// </summary>
        [HttpGet]
        public async Task<bool> GetEndSecondColNoFirstBool(string locationName)
        {
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var location = await dbSet.AsNoTracking().Where(t => t.LocationName == locationName && t.IsEnable == 1).FirstOrDefaultAsync();
            //一层 1601A 01 02 2        1601A 01 02 1   1601A 01 03 1
            if (location != null)
            {
                var bayId = location.BayId;
                var areaCode = location.AreaCode;
                var rowNo = location.RowNo;
                var leftColNo = location.ColNo;
                var rightColNo = location.ColNo + 1;

                var left = dbSet.AsNoTracking().FirstOrDefault(t => t.BayId == bayId &&
                                                           t.AreaCode == areaCode &&
                                                           t.RowNo == rowNo &&
                                                           t.ColNo == leftColNo &&
                                                           t.Type == 2 &&
                                                           t.IsEnable == 1 &&
                                                           t.FloorNo == 1);
                var right = dbSet.AsNoTracking().FirstOrDefault(t => t.BayId == bayId &&
                                                           t.AreaCode == areaCode &&
                                                           t.RowNo == rowNo &&
                                                           t.ColNo == rightColNo &&
                                                           t.Type == 2 &&
                                                           t.IsEnable == 1 &&
                                                           t.FloorNo == 1);
                if (left != null && right != null)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 查询在库鞍座
        /// </summary>
        [HttpGet]
        public async Task<List<LocationStartEndRead>> GetLocationTypes([FromQuery] BayAreaStackColRead basRead, CancellationToken cancellationToken)
        {
            var stackNo = await GetStackNo(basRead.StartStackId);
            var stackNo2 = await GetStackNo(basRead.EndStackId);

            var locationcolNo = await GetLocationColNo(basRead.StartColNoId);
            var locationcolNo2 = await GetLocationColNo(basRead.EndColNoId);

            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (basRead.AreaId.IsValidValue())
            {
                predicate = predicate.And(t => t.AreaId == basRead.AreaId);
            }
            predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2);
            predicate = predicate.And(t => t.RowNo >= stackNo && t.RowNo <= stackNo2);
            predicate = predicate.And(t => t.ColNo >= locationcolNo && t.ColNo <= locationcolNo2);

            //var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.ColNo).OrderByDescending(t => t.FloorNo).Take(basRead.PlanCount);
            var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.ColNo).OrderByDescending(t => t.FloorNo);
            var listResult = query.ToList();
            List<LocationStartEndRead> list = new();
            foreach (var item in listResult)
            {
                LocationStartEndRead ls = new();
                ls.Id = item.Id;
                ls.MaterialNo = item.MaterialNo;
                ls.Weight = item.Weight;
                ls.LoadLocationName = item.LocationName;
                ls.UnloadLocationName = "";
                ls.Diameter = item.Diameter;
                ls.InnerDiameter = item.InnerDiameter;
                list.Add(ls);
            }
            return list;
        }


        /// <summary>
        /// 库存对比
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<VCompareNameNoReadModel>>> GetVcomparePageQuery([FromQuery] PageParam pageParam,
            [FromQuery] string[] BayIdWms, [FromQuery] string type, [FromQuery] string locationNameWms, [FromQuery] string locationNameMes,
            [FromQuery] string matNoWms, [FromQuery] string matNoMes,
           [FromQuery] string[] stockNoWms, [FromQuery] string[] stockNoMes,
            CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<VCompareNameNo>();
            var dbSet = DataContext.Set<VCompareNameNo>();
            var query = dbSet.AsNoTracking();
            if (BayIdWms.Length > 0 && BayIdWms != null)
            {
                predicate = predicate.And(t => BayIdWms.Contains(t.BayIdWms));
            }
            if (!locationNameWms.IsNullOrEmpty())
            {
                predicate = predicate.And(t => t.LocationNameWms.Contains(locationNameWms));
            }
            if (!locationNameMes.IsNullOrEmpty())
            {
                predicate = predicate.And(t => t.LocationNameMes.Contains(locationNameMes));
            }
            if (!matNoWms.IsNullOrEmpty())
            {
                predicate = predicate.And(t => t.MatNoWms.Contains(matNoWms));
            }
            if (!matNoMes.IsNullOrEmpty())
            {
                predicate = predicate.And(t => t.MatNoMes.Contains(matNoMes));
            }
            if (!type.IsNullOrEmpty())
            {
                predicate = predicate.And(t => t.Type == Convert.ToInt32(type));
            }
            if (stockNoWms.Length > 0 && stockNoWms != null)
            {
                predicate = predicate.And(t => stockNoWms.Contains(t.StockNoWms));
            }
            if (stockNoMes.Length > 0 && stockNoMes != null)
            {
                predicate = predicate.And(t => stockNoMes.Contains(t.StockNoMes));
            }
            query = query.Where(predicate).OrderBy(t => t.LocationNameMes);
            var total = query.Count();
            if (pageParam != null)
            {
                query = query.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize);
            }
            else
            {
                query = query.Take(1000);
            }
            var results = await query
                .ProjectTo<VCompareNameNoReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new PageResult<VCompareNameNoReadModel>
            {
                Data = results,
                Success = true,
                Total = total
            };


        }

    }
}
