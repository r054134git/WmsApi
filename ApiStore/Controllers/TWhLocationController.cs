using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Wms.Telegram;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using Z.EntityFramework.Plus;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("store/[controller]/[action]")]
    public class TWhLocationController : EntityControllerBase<TWhLocation, TWhLocationReadModel, TWhLocationCreateModel, TWhLocationUpdateModel>
    {
        public TWhLocationController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhLocationCreateModel> createValidator, IValidator<TWhLocationUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        protected override async Task<OperationResult>
            CanCreate(TWhLocationCreateModel createModel, CancellationToken cancellationToken)
        {
            var isExist = await DataContext.Set<TUmUser>().
                AnyAsync(t => t.Name == createModel.Name, cancellationToken);
            if (isExist)
            {
                return new OperationResult(false, $"{createModel.Name}的库位已经存在，创建失败！");
            }
            return new OperationResult(true, $"{createModel.Name}的库位创建成功！");
        }


        [HttpGet("")]
        public async Task<PageResult<TWhLocationReadModel>>
            GetListQuery([FromQuery] string[] bayId, [FromQuery] string[] areaId,
                        [FromQuery] string[] ownerId, CancellationToken cancellationToken)
        {
            //var predicate = ExpressionBuilder.True<TWhLocation>();
            //if (locationId.IsValidValue())
            //{
            //	predicate = predicate.And(t => t.Id == locationId);
            //}

            //var query = GetQueryable(predicate);
            //var listResult = await ReadModel(query, cancellationToken);

            //return listResult;
            return null;
        }

        /// <summary>
        /// 库位信息筛选
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhLocationReadModel>>>
            GetPageQuery([FromQuery] PageParam pageParam, [FromQuery] string[] bayId,
                        [FromQuery] string[] areaId, [FromQuery] string[] ownerId, [FromQuery] int[] floorNo, [FromQuery] int[] orientation,
                        [FromQuery] int[] isVirtual, [FromQuery] int[] storageType, [FromQuery] int[] loadType, [FromQuery] int[] isEnable,
                        CancellationToken cancellationToken)
        {
            try
            {
                var predicate = ExpressionBuilder.True<TWhLocation>();
                if (bayId.Length > 0 && bayId != null)
                {
                    predicate = predicate.And(t => bayId.Contains(t.BayId));
                }
                if (areaId.Length > 0 && areaId != null)
                {
                    predicate = predicate.And(t => areaId.Contains(t.AreaId));
                }
                if (ownerId.Length > 0 && ownerId != null)
                {
                    predicate = predicate.And(t => ownerId.Contains(t.OwnerId));
                }
                if (floorNo.Length > 0 && floorNo != null)
                {
                    predicate = predicate.And(t => floorNo.Contains(t.FloorNo));
                }
                if (orientation.Length > 0 && orientation != null)
                {
                    predicate = predicate.And(t => orientation.Contains(t.Orientation));
                }
                if (isVirtual.Length > 0 && isVirtual != null)
                {
                    predicate = predicate.And(t => isVirtual.Contains(t.IsVirtual));
                }
                if (storageType.Length > 0 && storageType != null)
                {
                    predicate = predicate.And(t => storageType.Contains(t.StorageType));
                }
                if (loadType.Length > 0 && loadType != null)
                {
                    predicate = predicate.And(t => loadType.Contains(t.LoadType));
                }
                if (isEnable.Length > 0 && isEnable != null)
                {
                    predicate = predicate.And(t => isEnable.Contains(t.IsEnable));
                }
                var query = GetQueryOrderByIdAsc(predicate);
                //.OrderByDescending(t => t.Id).Include(t => t.TeamTScDictionary).Include(T => T.RoleTUmRole);

                var listResult = await QueryPageModel(query, pageParam, cancellationToken);


                return Ok(listResult);
            }
            catch (Exception ex)
            {
                return NoContent();
            }

        }

        /// <summary>
        /// 库位批量禁用
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<TWhLocationReadModel>>>
            UpdateLocationDisabled([FromQuery] string[] ids, string remark, CancellationToken cancellationToken)
        {
            var locations = DataContext.Set<TWhLocation>();
            var trLocations = DataContext.Set<TTrLocationMaterial>();
            foreach (var item in ids)
            {
                var model = locations.Where(t => t.Id == item).FirstOrDefault();
                model.IsEnable = 0;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = "API";
                model.Remark = remark;
                var tr = trLocations.Where(t => t.LocationId == item).FirstOrDefault();
                tr.IsEnable = 0;
                tr.UpdateTime = DateTime.Now;
                tr.UpdateUser = "API";
                model.Remark = remark;
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count > 0)
            {
                return Ok(true);
            }
            return Ok(false);
        }

        /// <summary>
        /// 库位批量启用
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<TWhLocationReadModel>>>
            UpdateLocationIsEnable([FromQuery] string[] ids, string remark, CancellationToken cancellationToken)
        {
            var locations = DataContext.Set<TWhLocation>();
            var trLocations = DataContext.Set<TTrLocationMaterial>();
            foreach (var item in ids)
            {
                var model = locations.Where(t => t.Id == item).FirstOrDefault();
                model.IsEnable = 1;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = "API";
                model.Remark = remark;
                var tr = trLocations.Where(t => t.LocationId == item).FirstOrDefault();
                tr.IsEnable = 1;
                tr.UpdateTime = DateTime.Now;
                tr.UpdateUser = "API";
                model.Remark = remark;
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count > 0)
            {
                return Ok(true);
            }
            return Ok(false);
        }

        [HttpGet("")]
        public async Task<TWhLocationReadModel>
            GetLocation(string locationId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhLocation>();
            if (locationId.IsValidValue())
            {
                predicate = predicate.And(t => t.Id == locationId);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);

            return listResult;
        }

        [HttpGet("")]
        public async Task<TWhLocationReadModel>
            GetLocationByName(string locationName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhLocation>();
            if (locationName.IsValidValue())
            {
                predicate = predicate.And(t => t.Name == locationName);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);

            return listResult;
        }

        [HttpPut("")]
        public async Task<ActionResult<OperationResult<TWhLocationReadModel>>>
            HoldUpdateLocation(string locationId, decimal pointX, decimal pointY, int isEnable, CancellationToken cancellationToken)
        {
            var repoLog = DataContext.Set<TRcLog>();
            var whLocation = DataContext.Set<TWhLocation>();
            var trLocationMaterial = DataContext.Set<TTrLocationMaterial>();
            if (locationId.IsValidValue())
            {
                var location = whLocation.Where(t => t.Id == locationId).FirstOrDefault();
                var trlocation = trLocationMaterial.Where(t => t.LocationId == locationId).FirstOrDefault();
                var log = new TRcLog
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    Source = "API",
                    WarningLevel = "INFO",
                    Message = $"{location.Name}库位X{location.PointX} 更改为{pointX},Y{location.PointY} 更改为{pointY},{isEnable}"
                };
                location.PointX = pointX;
                location.PointY = pointY;
                location.IsEnable = isEnable;

                trlocation.PointX = pointX;
                trlocation.PointY = pointY;
                trlocation.IsEnable = isEnable;
                repoLog.Add(log);
                await DataContext.SaveChangesAsync();
                var result = whLocation.Where(t => t.Id == locationId)
                .ProjectTo<TWhLocationReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                return new OperationResult<TWhLocationReadModel>(true, "信息更改成功", result);
            }
            return new OperationResult<TWhLocationReadModel>(false, "未找到库位信息", null);
        }

        [HttpPut("")]
        public async Task<ActionResult<int>>
            UpdateLocation(TWhLocationReadModel location, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhLocation>();
            if (location.Id.IsValidValue())
            {
                predicate = predicate.And(t => t.Id == location.Id);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        [HttpPost("")]
        public async Task<ActionResult<bool>>
            BatchCreateLocations(BatchCreateLocationParam param, CancellationToken cancellationToken)
        {
            var bay = DataContext.Set<TWhBay>().FirstOrDefault(t => t.Id == param.BayId);
            var area = DataContext.Set<TWhArea>().FirstOrDefault(t => t.Id == param.AreaId);
            if (bay == null || area == null)
            {
                return false;
            }
            var identityName = User.Identity?.Name;
            if (string.IsNullOrWhiteSpace(identityName))
            {
                identityName = "API";
            }

            //12代表一层和二层
            if (param.FloorNo != 1 && param.FloorNo != 2 && param.FloorNo != 12)
            {
                return false;
            }

            if (param.FloorNo == 12)
            {
                await AddLocations(param, bay, area, 1, identityName, cancellationToken);
                await AddLocations(param, bay, area, 2, identityName, cancellationToken);
            }
            else
            {
                await AddLocations(param, bay, area, param.FloorNo, identityName, cancellationToken);
            }

            await DataContext.SaveChangesAsync(cancellationToken);
            return Ok(true);
        }

        private async Task AddLocations(BatchCreateLocationParam param,
            TWhBay bay, TWhArea area, int floorNo, string identityName,
            CancellationToken cancellationToken)
        {
            var rowSpacing = (param.ToY - param.FromY) / (param.ToStackNo - param.FromStackNo + 1);
            var colSpacing = (param.ToX - param.FromX) / (param.ToColNo - param.FromColNo + 1);
            var fromX = param.FromX;
            var fromY = param.FromY;

            if (floorNo == 2 && param.FloorNo == 12)
            {
                fromX += colSpacing / 2;
                param.ToColNo -= 1;
            }
            var pushLocList = new List<TWhLocation>();
            for (int row = param.FromStackNo; row <= param.ToStackNo; row++)
            {
                var stack = await DataContext.Set<TWhStack>()
                    .FirstOrDefaultAsync(t => t.BayId == param.BayId &&
                                         t.OwnerId == param.AreaId && t.StackNo == row);
                if (stack == null)
                {
                    stack = new TWhStack
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        Name = $"{bay.Name}-{area.Name}-{row}行",
                        Width = 2,
                        Length = 20,
                        PointX = param.FromX,
                        PointY = param.FromY + (row - param.FromStackNo) * rowSpacing,
                        OwnerId = area.Id,
                        BayId = bay.Id,
                        MaxFloor = 2,
                        UnloadMinWidth = 0,
                        StackNo = row,
                        Orientation = param.Orientation,
                        Type = 1,
                        IsLockable = 0,
                        AreaNo = area.Code,
                        LoadOrder = 0,
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"
                    };

                    await DataContext.Set<TWhStack>().AddAsync(stack, cancellationToken);
                }


                for (int col = param.FromColNo; col <= param.ToColNo; col++)
                {
                    var location = new TWhLocation
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        Name = $"{bay.Code}{area.Code}{row:D2}{col:D2}{floorNo}",
                        BayCode = bay.Code,
                        AreaCode = area.Code,
                        RowNo = row,
                        ColNo = col,
                        FloorNo = floorNo,
                        PointX = fromX + (col - param.FromColNo) * colSpacing,
                        PointY = param.FromY + (row - param.FromStackNo) * rowSpacing,
                        PointZ = 1,
                        DevX = 0,
                        DevY = 0,
                        Angle = param.Angle,
                        Orientation = param.Orientation,
                        MaxZ = 2,
                        BaseWidth = 2,
                        BaseLength = 2,
                        BaseHeight = 0.1M,
                        OwnerId = stack.Id,
                        StorageType = param.StorageType,
                        LoadType = param.LoadType,
                        //补充跨/区中的数据到库位数据
                        BayId = param.BayId,
                        AreaId = param.AreaId,
                        IsVirtual = area.IsVirtual,
                        OwnerBussinessName = area.OwnerBussinessName,
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"
                    };
                    await DataContext.Set<TWhLocation>().AddAsync(location, cancellationToken);
                    pushLocList.Add(location);

                    var lm = new TTrLocationMaterial()
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        LocationId = location.Id,
                        LocationName = location.Name,
                        BayCode = bay.Code,
                        AreaCode = area.Code,
                        RowNo = row,
                        ColNo = col,
                        FloorNo = floorNo,
                        PointX = fromX + (col - param.FromColNo) * colSpacing,
                        PointY = param.FromY + (row - param.FromStackNo) * rowSpacing,
                        PointZ = 1,
                        Angle = param.Angle,
                        MaxZ = 2,
                        BaseWidth = 2,
                        BaseLength = 2,
                        BaseHeight = 0.1M,
                        StorageType = param.StorageType,
                        LoadType = param.LoadType,
                        //补充跨/区中的数据到库位数据
                        WarehouseId = bay.OwnerId,
                        BayId = param.BayId,
                        AreaId = param.AreaId,
                        StackId = stack.Id,
                        IsVirtual = area.IsVirtual,
                        OwnerBussinessName = area.OwnerBussinessName,
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"
                    };
                    await DataContext.Set<TTrLocationMaterial>().AddAsync(lm, cancellationToken);
                }

            }

            await DataContext.SaveChangesAsync(cancellationToken);
            var userAccount = User.GetUserName();
            var mbs = ServiceProvider.GetService<MbsProxy>();
            foreach (var pushLoc in pushLocList)
            {
                TeleWMBM21 tele21 = new TeleWMBM21
                {
                    Payload = new LocationInfo
                    {
                        OperationMark = "E",
                        House = pushLoc.OwnerBussinessName,
                        BayAreaNo = pushLoc.BayCode + pushLoc.AreaCode,
                        RowNo = pushLoc.RowNo.ToString(),
                        ColumnNo = pushLoc.ColNo.ToString(),
                        TierNo = pushLoc.FloorNo.ToString(),
                        LocationNo = pushLoc.Name,
                        LocationType = pushLoc.IsVirtual == 0 ? "0" : "9",
                        Operator = userAccount,
                        CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                    }
                };
                await mbs.Publish(tele21);
            }
        }

        /// <summary>
        /// 批量更新鞍座行列坐标
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<bool>>
            BatchUpdateLocationXY(BatchAdjustXyParam param, CancellationToken cancellationToken)
        {
            var logs = DataContext.Set<TRcLog>();
            var locations = DataContext.Set<TWhLocation>()
                .Where(t => t.OwnerId == param.StackId &&
                            t.ColNo >= param.FromColNo &&
                            t.ColNo <= param.ToColNo).OrderBy(t => t.FloorNo).ThenBy(t => t.ColNo).ToList();
            var lms = DataContext.Set<TTrLocationMaterial>()
                .Where(t => t.StackId == param.StackId &&
                            t.ColNo >= param.FromColNo &&
                            t.ColNo <= param.ToColNo).OrderBy(t => t.FloorNo).ThenBy(t => t.ColNo).ToList();
            foreach (var location in locations)
            {
                location.PointX += param.OffsetX;
                location.PointY += param.OffsetY;
            }
            foreach (var lm in lms)
            {
                lm.PointX += param.OffsetX;
                lm.PointY += param.OffsetY;
            }
            var log = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"客户端调整库位{lms.FirstOrDefault().LocationName}至{lms.OrderByDescending(t => t.ColNo).FirstOrDefault().LocationName},X坐标{param.OffsetX},Y坐标{param.OffsetY}",
                Source = "API"
            };
            logs.Add(log);
            await DataContext.SaveChangesAsync(cancellationToken);

            return Ok(true);
        }

        /// <summary>
        /// 批量更改鞍座行间距
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<bool>>
            BatchUpdateLocationSpacing(BatchSpacingParam param, CancellationToken cancellationToken)
        {
            var logs = DataContext.Set<TRcLog>();
            var locations = DataContext.Set<TWhLocation>()
                .Where(t => t.OwnerId == param.StackId && t.ColNo >= param.FromColNo && t.ColNo <= param.ToColNo && t.FloorNo == 1).OrderBy(t => t.ColNo).ToList();
            var trLM = DataContext.Set<TTrLocationMaterial>()
                .Where(t => t.StackId == param.StackId && t.ColNo >= param.FromColNo && t.ColNo <= param.ToColNo && t.FloorNo == 1).OrderBy(t => t.ColNo).ToList();
            if (param.Count == 1)
            {
                foreach (var item in locations)
                {
                    item.PointX = param.ToX;
                    item.PointY = param.ToY;
                }
                foreach (var item in trLM)
                {
                    foreach (var l in locations)
                    {
                        if (item.LocationId == l.Id)
                        {
                            item.PointX = param.ToX;
                            item.PointY = param.ToY;
                        }
                    }
                }
                await DataContext.SaveChangesAsync(cancellationToken);
                return Ok(true);
            }
            var interval = (param.ToX - param.FromX) / (param.Count - 1);
            var i = 1;
            var t = 1;
            foreach (var item in locations)
            {
                var a = i * interval + (param.FromX - interval);
                item.PointX = a;
                item.PointY = param.ToY;
                i++;

            }
            foreach (var item in trLM)
            {
                foreach (var l in locations)
                {
                    if (item.LocationId == l.Id)
                    {
                        var x = t * interval + (param.FromX - interval);
                        item.PointX = x;
                        item.PointY = param.ToY;
                        t++;
                    }
                }
            }
            var log = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"客户端调整库位间距{trLM.FirstOrDefault().LocationName}至{trLM.OrderByDescending(t => t.ColNo).FirstOrDefault().LocationName},X坐标{param.FromX}至{param.ToX},Y坐标{param.ToY}，个数{param.Count}",
                Source = "API"
            };
            logs.Add(log);
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count != 0)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }
        /// <summary>
        /// 创建库位
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> SendMesInfo(TWhLocationCreateModel createModel, CancellationToken cancellationToken)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();

            TeleWMBM21 tele21 = new TeleWMBM21
            {
                Payload = new LocationInfo
                {
                    OperationMark = "E",
                    House = createModel.OwnerBussinessName,
                    BayAreaNo = createModel.BayCode + createModel.AreaCode,
                    RowNo = createModel.RowNo.ToString(),
                    ColumnNo = createModel.ColNo.ToString(),
                    TierNo = createModel.FloorNo.ToString(),
                    LocationNo = createModel.Name,
                    LocationType = createModel.IsVirtual == 0 ? "0" : "9",
                    Operator = createModel.CreateUser,
                    CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                }
            };
            await mbs.Publish(tele21);

            return new OperationResult(true, "");
        }
        [HttpPost("")]
        public override async Task<ActionResult<OperationResult>>
            Create(TWhLocationCreateModel createModel, CancellationToken cancellationToken)
        {
            var area = await DataContext.Set<TWhArea>().FirstOrDefaultAsync(t => t.Id == createModel.AreaId);
            if (area == null)
            {
                return new OperationResult(false, "选择的区域数据不存在！");
            }
            var bay = await DataContext.Set<TWhBay>().FirstOrDefaultAsync(t => t.Id == createModel.BayId);
            if (bay == null)
            {
                return new OperationResult(false, "选择的单跨数据不存在！");
            }
            var stack = await DataContext.Set<TWhStack>().FirstOrDefaultAsync(t => t.Id == createModel.OwnerId);
            if (stack == null)
            {
                return new OperationResult(false, "选择的垛位数据不存在！");
            }

            createModel.Name = $"{bay.Code}{area.Code}{stack.StackNo:D2}{createModel.ColNo:D2}{createModel.FloorNo}";
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }

            //补充跨/区中的数据到库位数据
            createModel.BayCode = bay.Code;
            createModel.AreaCode = area.Code;
            createModel.IsVirtual = area.IsVirtual;
            createModel.OwnerBussinessName = area.OwnerBussinessName;

            SetCreateModelBasic(createModel);

            //校验数据
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);

            var location = Mapper.Map<TWhLocation>(createModel);

            //t_tr_location_material
            var trlmModel = new TTrLocationMaterialCreateModel();
            trlmModel = Mapper.Map(createModel, trlmModel);
            var trlm = Mapper.Map<TTrLocationMaterial>(trlmModel);
            trlm.WarehouseId = bay.OwnerId;
            trlm.StackId = createModel.OwnerId;
            var identityName = createModel.Name;
            trlm.Id = IdWorkerGenerator.Instance.NextId().ToString();
            trlm.IsEnable = 1;
            trlm.CreateTime = DateTime.Now;
            trlm.CreateUser = "API";
            trlm.UpdateTime = DateTime.Now;
            trlm.UpdateUser = "API";
            await DataContext.Set<TWhLocation>()
                .AddAsync(location, cancellationToken);
            await DataContext.Set<TTrLocationMaterial>()
                .AddAsync(trlm, cancellationToken);

            await DataContext.SaveChangesAsync(cancellationToken);

            var userAccount = User.GetUserName();
            var mbs = ServiceProvider.GetService<MbsProxy>();
            TeleWMBM21 tele21 = new TeleWMBM21
            {
                Payload = new LocationInfo
                {
                    OperationMark = "E",
                    House = createModel.OwnerBussinessName,
                    BayAreaNo = createModel.BayCode + createModel.AreaCode,
                    RowNo = createModel.RowNo.ToString(),
                    ColumnNo = createModel.ColNo.ToString(),
                    TierNo = createModel.FloorNo.ToString(),
                    LocationNo = createModel.Name,
                    LocationType = createModel.StorageType <= 2 ? "0" : "9",
                    Operator = userAccount,
                    CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                }
            };
            if (createModel.StorageType <= 2 || createModel.StorageType == 13)
            {
                await mbs.Publish(tele21);
            }

            return operationResult;
        }

        [HttpPut("{id}")]
        public override async Task<ActionResult<OperationResult>>
            Update(string id, TWhLocationUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);


            var area = await DataContext.Set<TWhArea>().FirstOrDefaultAsync(t => t.Id == updateModel.AreaId);
            if (area == null)
            {
                return new OperationResult(false, "选择的区域数据不存在！");
            }
            var bay = await DataContext.Set<TWhBay>().FirstOrDefaultAsync(t => t.Id == updateModel.BayId);
            if (bay == null)
            {
                return new OperationResult(false, "选择的单跨数据不存在！");
            }
            var stack = await DataContext.Set<TWhStack>().FirstOrDefaultAsync(t => t.Id == updateModel.OwnerId);
            if (stack == null)
            {
                return new OperationResult(false, "选择的垛位数据不存在！");
            }
            updateModel.Name = $"{bay.Code}{area.Code}{stack.StackNo:D2}{updateModel.ColNo:D2}{updateModel.FloorNo}";

            var isExist = await DataContext.Set<TUmUser>()
                .AnyAsync(t => t.Name == updateModel.Name, cancellationToken);
            if (isExist)
            {
                return new OperationResult(false, $"{updateModel.Name}的库位已经存在，创建失败！");
            }

            //补充跨/区中的数据到库位数据
            updateModel.BayCode = bay.Code;
            updateModel.AreaCode = area.Code;
            updateModel.IsVirtual = area.IsVirtual;
            // updateModel.OwnerBussinessName = area.OwnerBussinessName;

            //校验数据
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken);

            //t_wh_location表更新
            var keyValue = new object[] { id };
            var location = await DataContext
                .Set<TWhLocation>()
                .FindAsync(keyValue, cancellationToken);
            Mapper.Map(updateModel, location);

            //t_tr_location_material表更新
            var trlm = DataContext.Set<TTrLocationMaterial>().First(t => t.LocationId == id);
            Mapper.Map(updateModel, trlm);
            trlm.WarehouseId = bay.OwnerId;
            trlm.StackId = updateModel.OwnerId;

            //提交所有更改
            await DataContext.SaveChangesAsync(cancellationToken);

            var readModel = await ReadModel(id, cancellationToken);

            return new OperationResult(true, "数据更新成功");
        }

        [HttpDelete]
        public override async Task<ActionResult<OperationResult>>
            Delete([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var userAccount = User.GetUserName();
            var idsString = string.Join(",", ids);
            try
            {
                var lcount = DataContext
                    .Set<TWhLocation>().Where(t => ids.Contains(t.Id));
                var deleCount = lcount.Delete();
                if (lcount.Count() > 0)
                {
                    var mbs= ServiceProvider.GetService<MbsProxy>();
                    foreach (var pushLoc in lcount) 
                    {
                        TeleWMBM21 tele21 = new TeleWMBM21
                        {
                            Payload = new LocationInfo
                            {
                                OperationMark = "G",
                                House = pushLoc.OwnerBussinessName,
                                BayAreaNo = pushLoc.BayCode + pushLoc.AreaCode,
                                RowNo = pushLoc.RowNo.ToString(),
                                ColumnNo = pushLoc.ColNo.ToString(),
                                TierNo = pushLoc.FloorNo.ToString(),
                                LocationNo = pushLoc.Name,
                                LocationType = pushLoc.IsVirtual == 0 ? "0" : "9",
                                Operator = userAccount,
                                CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                            }
                        };
                        await mbs.Publish(tele21);
                    }
                }
                var lmcount = DataContext
                    .Set<TTrLocationMaterial>().Where(t => ids.Contains(t.LocationId)).Delete();

                await DataContext
                    .SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                return new OperationResult(false, ex.Message);
            }

            return new OperationResult(true, $"id {idsString} 的数据删除成功！");
        }


        /// <summary>
        /// 批量更新区域类型
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateLocationBuss([FromQuery] string bayId, [FromQuery] string areaId, [FromQuery] string stackId, [FromQuery] string buss, CancellationToken cancellationToken)
        {
            var locations = DataContext.Set<TWhLocation>();
            var trLocations = DataContext.Set<TTrLocationMaterial>();

            var query = locations.AsNoTracking();
            if (bayId.IsValidValue())
            {
                query = query.Where(t => t.BayId == bayId);
            }
            if (areaId.IsValidValue())
            {
                query = query.Where(t => t.AreaId == areaId);
            }
            if (stackId.IsValidValue())
            {
                query = query.Where(t => t.OwnerId == stackId);
            }
            var locationsList = query.ToList();

            foreach (var item in locationsList)
            {
                var model = locations.Where(t => t.Id == item.Id).FirstOrDefault();
                model.OwnerBussinessName = buss;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = "API";
                var tr = trLocations.Where(t => t.LocationId == item.Id).FirstOrDefault();
                tr.OwnerBussinessName = buss;
                tr.UpdateTime = DateTime.Now;
                tr.UpdateUser = "API";
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count > 0) return new OperationResult(true, $"更新区域类型成功！");
            return new OperationResult(false, $"更新区域类型失败！");
        }


        /// <summary>
        /// 批量更新库位类型
        /// </summary>
        /// <returns></returns>
        [TokenActionFilter]
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateLocationStorageType([FromQuery] string bayId, [FromQuery] string areaId, [FromQuery] string stackId, [FromQuery] int storageType, CancellationToken cancellationToken)
        {
            var userAccount = User.GetUserName();
            var locations = DataContext.Set<TWhLocation>();
            var trLocations = DataContext.Set<TTrLocationMaterial>();

            var query = locations.AsNoTracking();
            if (bayId.IsValidValue())
            {
                query = query.Where(t => t.BayId == bayId);
            }
            if (areaId.IsValidValue())
            {
                query = query.Where(t => t.AreaId == areaId);
            }
            if (stackId.IsValidValue())
            {
                query = query.Where(t => t.OwnerId == stackId);
            }
            var locationsList = query.ToList();

            foreach (var item in locationsList)
            {
                var model = locations.Where(t => t.Id == item.Id).FirstOrDefault();
                model.StorageType = storageType;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = userAccount;
                var tr = trLocations.Where(t => t.LocationId == item.Id).FirstOrDefault();
                tr.StorageType = storageType;
                tr.UpdateTime = DateTime.Now;
                tr.UpdateUser = userAccount;
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count > 0) return new OperationResult(true, $"更新库位类型成功！");
            return new OperationResult(false, $"更新库位类型失败！");
        }


        /// <summary>
        /// 获取列号
        /// </summary>
        /// <param name="stackId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhLocationReadModel>>> GetListOfLocation(string stackId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhLocation>();
            if (stackId.IsValidValue())
            {
                predicate = predicate.And(t => t.OwnerId == stackId);
            }
            predicate = predicate.And(t => t.IsEnable == 1 && t.FloorNo == 1);
            var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.ColNo);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }


        //库位变更  03A-02A   加五列
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateLocationNameAndColNo(string baycode, string areacode, int addnum, CancellationToken cancellationToken)
        {
            var locations = DataContext.Set<TWhLocation>();
            var trLocations = DataContext.Set<TTrLocationMaterial>();
            var whAreas = DataContext.Set<TWhArea>();
            if (baycode.IsValidValue() && areacode.IsValidValue())
            {
                var query = locations.AsNoTracking();
                var locationsList = query.Where(t => t.BayCode == baycode && t.AreaCode == areacode).OrderByDescending(t => t.ColNo).ToList();
                foreach (var item in locationsList)
                {
                    var areaModel = whAreas.Where(t => t.Id == item.AreaId).FirstOrDefault();
                    var locationModel = locations.Where(t => t.Id == item.Id).FirstOrDefault();
                    var trLocationModel = trLocations.Where(t => t.LocationId == item.Id).FirstOrDefault();
                    if (areaModel != null)
                    {
                        //03-02A 
                        locationModel.AreaCode = areaModel.Code;
                        locationModel.ColNo = item.ColNo + addnum;
                        locationModel.Name = $"{item.BayCode}{areaModel.Code}{item.RowNo:D2}{(item.ColNo + addnum):D2}{item.FloorNo}";

                        trLocationModel.AreaCode = areaModel.Code;
                        trLocationModel.ColNo = item.ColNo + addnum;
                        trLocationModel.LocationName = $"{item.BayCode}{areaModel.Code}{item.RowNo:D2}{(item.ColNo + addnum):D2}{item.FloorNo}";
                        await DataContext.SaveChangesAsync(cancellationToken);
                    }
                }
            }
            return new OperationResult(false, $"更新库位成功！");
        }

    }
}
