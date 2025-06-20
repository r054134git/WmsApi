using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq;
using Cds.Contracts;
using Ucp.Contracts;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper.QueryableExtensions;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("store/[controller]/[action]")]
    public class TWhCraneTravelSpaceController : EntityControllerBase<TWhCraneTravelSpace, TWhCraneTravelSpaceReadModel, TWhCraneTravelSpaceCreateModel, TWhCraneTravelSpaceUpdateModel>
    {
        private IServiceProvider _serviceProvider { get; set; }
        public TWhCraneTravelSpaceController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhCraneTravelSpaceCreateModel> createValidator, IValidator<TWhCraneTravelSpaceUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
            _serviceProvider = serviceProvider;
        }
        [HttpPut("")]
        public async Task<ActionResult<OperationResult<TWhCraneTravelSpaceReadModel>>> UpdateTravelSpace(string bayId, string id, int isEnable, CancellationToken cancellationToken)
        {
            var repo = DataContext.Set<TWhCraneTravelSpace>();
            var logs = DataContext.Set<TRcLog>();
            if (bayId == "1510159484113915904")
            {
                var stateC = repo.Where(t => t.Id == "1727897368949166080").FirstOrDefault();
                var stateD = repo.Where(t => t.Id == "1727897551518830592").FirstOrDefault();
                var state = repo.Where(t => t.Id == id).FirstOrDefault();
                if (id == "1727897368949166080" && stateD.IsEnable == 1 && isEnable == 1 ||
                    id == "1727897551518830592" && stateC.IsEnable == 1 && isEnable == 1) //不可同时启用
                {
                    return new OperationResult<TWhCraneTravelSpaceReadModel>(false, "包装区域C和包装区域D不可同时进入", null);
                }
                if (id == "1727897368949166080" && isEnable == 1 && stateD.IsEnable == 0) //D区禁用C区启用 绿灯
                {
                    if (state.IsEnable != isEnable)
                    {
                        state.IsEnable = isEnable;
                    }

                    GroundStateCommand groundStateCommand = new GroundStateCommand();
                    groundStateCommand.PartnerId = new Key("Ground-PLC", "Ground-PLC", 0);
                    groundStateCommand.StateType = 2;
                    groundStateCommand.Name = "Light.W22.2";
                    groundStateCommand.Value = 2;
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(groundStateCommand);
                    var log = new TRcLog
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        WarningLevel = "INFO",
                        Message = $"手持机更改22库D区禁用C区启用，转换为绿灯",
                        Source = "API"
                    };
                    logs.Add(log);
                    await DataContext.SaveChangesAsync();
                    var states = repo.Where(t => t.Id == id).ProjectTo<TWhCraneTravelSpaceReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                    return new OperationResult<TWhCraneTravelSpaceReadModel>(true, "操作成功", states);
                }
                if (id == "1727897551518830592" && isEnable == 1 && stateC.IsEnable == 0) //C区禁用D区启用 红灯
                {
                    if (state.IsEnable != isEnable)
                    {
                        state.IsEnable = isEnable;
                    }
                    GroundStateCommand groundStateCommand = new GroundStateCommand();
                    groundStateCommand.PartnerId = new Key("Ground-PLC", "Ground-PLC", 0);
                    groundStateCommand.StateType = 2;
                    groundStateCommand.Name = "Light.W22.2";
                    groundStateCommand.Value = 1;
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(groundStateCommand);
                    var log = new TRcLog
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        WarningLevel = "INFO",
                        Message = $"手持机更改22库C区禁用D区启用，转换为红灯",
                        Source = "API"
                    };
                    logs.Add(log);
                    await DataContext.SaveChangesAsync();
                    var states = repo.Where(t => t.Id == id).ProjectTo<TWhCraneTravelSpaceReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                    return new OperationResult<TWhCraneTravelSpaceReadModel>(true, "操作成功", states);
                }
                if (id == "1727897368949166080" && stateD.IsEnable == 0 && isEnable == 0 ||
                    id == "1727897551518830592" && stateC.IsEnable == 0 && isEnable == 0) //同时禁用  不亮
                {
                    if (state.IsEnable != isEnable)
                    {
                        state.IsEnable = isEnable;
                    }
                    GroundStateCommand groundStateCommand = new GroundStateCommand();
                    groundStateCommand.PartnerId = new Key("Ground-PLC", "Ground-PLC", 0);
                    groundStateCommand.StateType = 2;
                    groundStateCommand.Name = "Light.W22.2";
                    groundStateCommand.Value = 0;
                    var mbs = _serviceProvider.GetService<MbsProxy>();
                    await mbs.Publish(groundStateCommand);
                    var log = new TRcLog
                    {
                        Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        WarningLevel = "INFO",
                        Message = $"手持机更改22库C区D区同时禁用，红绿灯不亮",
                        Source = "API"
                    };
                    logs.Add(log);
                    await DataContext.SaveChangesAsync();
                    var states = repo.Where(t => t.Id == id).ProjectTo<TWhCraneTravelSpaceReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                    return new OperationResult<TWhCraneTravelSpaceReadModel>(true, "操作成功", states);
                }
            }
            else if (bayId == "1510159712544100352")
            {
                var state = repo.Where(t => t.OwnerId == bayId && t.Id == id).FirstOrDefault();
                if (state.IsEnable != isEnable)
                {
                    state.IsEnable = isEnable;
                }
                await DataContext.SaveChangesAsync();
                var states = repo.Where(t => t.OwnerId == bayId && t.Id == id).ProjectTo<TWhCraneTravelSpaceReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                return new OperationResult<TWhCraneTravelSpaceReadModel>(true, "操作成功", states);
            }

            return new OperationResult<TWhCraneTravelSpaceReadModel>(true, "操作失败", null);
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhCraneTravelSpaceReadModel>>>
            GetAllAreaBayId(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhCraneTravelSpace>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(x => x.OwnerId == bayId && x.IsEnable == 1);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }
    }
}
