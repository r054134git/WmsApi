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
    [Route("tracker/[controller]/[action]")]
    public class TTrTrafficLightController : EntityControllerBase<TTrTrafficLight, TTrTrafficLightReadModel, TTrTrafficLightCreateModel, TTrTrafficLightUpdateModel>
    {
        private IServiceProvider _serviceProvider { get; set; }
        public TTrTrafficLightController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrTrafficLightCreateModel> createValidator, IValidator<TTrTrafficLightUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
            _serviceProvider = serviceProvider;
        }
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateTrafficLight(string name, int type, CancellationToken cancellationToken)
        {
            var repo = DataContext.Set<TWhCraneTravelSpace>();
            var logs = DataContext.Set<TRcLog>();

            var stateC = repo.Where(t => t.Name == name).FirstOrDefault();

            GroundStateCommand groundStateCommand = new GroundStateCommand();
            groundStateCommand.PartnerId = new Key("Ground-PLC", "Ground-PLC", 0);
            groundStateCommand.StateType = 2;
            groundStateCommand.Name = name;
            groundStateCommand.Value = type;
            var mbs = _serviceProvider.GetService<MbsProxy>();
            await mbs.Publish(groundStateCommand);
            await DataContext.SaveChangesAsync();
            return new OperationResult(true, "²Ù×÷³É¹¦");
        }
    }
}
