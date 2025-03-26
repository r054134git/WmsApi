using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;
using WmsApi.Domain;
using Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper.QueryableExtensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TScTransferSpecController : EntityControllerBase<TScTransferSpec, TScTransferSpecReadModel, TScTransferSpecCreateModel, TScTransferSpecUpdateModel>
    {
        public TScTransferSpecController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TScTransferSpecCreateModel> createValidator, IValidator<TScTransferSpecUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 宽度/左侧
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<TScTransferSpecReadModel>>>>
            GetAllTransferSpecLeft(int belongSpecWidth, CancellationToken cancellationToken)
        {
            List<TScTransferSpecReadModel> result = new List<TScTransferSpecReadModel>();
            var u127List = await DataContext.Set<VPlMaterial>().Where(t => t.Type == 2 && (t.MatDirection == "U127" || t.TrnpModeCode == "A") && t.DecideWidth > 0).ToListAsync();
            if (u127List.Count > 0)
            {
                var belongWidthList = DataContext.Set<TScTransferSpec>().Where(t => t.BelongSpecWidth == belongSpecWidth && t.SpecWidth > 0).ToList();
                var sepcWidthList = new List<int?>();
                if (belongWidthList.Count > 0)
                {
                    sepcWidthList = belongWidthList.Select(t => t.SpecWidth).ToList();
                }
                var distinctWidth = u127List.Select(t => t.DecideWidth).Distinct();
                foreach (var width in distinctWidth)
                {
                    if (!sepcWidthList.Contains(width))
                    {
                        TScTransferSpecReadModel model = new()
                        {
                            SpecWidth = width,
                        };
                        result.Add(model);
                    }
                }
            }
            return new OperationResult<List<TScTransferSpecReadModel>>(true, "", result);
        }

        /// <summary>
        /// 宽度/右侧
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<TScTransferSpecReadModel>>>>
            GetAllTransferSpecRight(int belongSpecWidth, int specWidth, CancellationToken cancellationToken)
        {
            var query = DataContext.Set<TScTransferSpec>().AsNoTracking().Where(t => t.BelongSpecWidth.Equals(belongSpecWidth) && t.SpecWidth > 0);
            var trs = await query.ProjectTo<TScTransferSpecReadModel>(Mapper.ConfigurationProvider)
                                                   .ToListAsync(cancellationToken);
            return new OperationResult<List<TScTransferSpecReadModel>>(true, "", trs);
        }
    }
}
