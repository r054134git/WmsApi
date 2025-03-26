using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain.Entities;
using WmsApi.Domain;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiniExcelLibs;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcBayTransfersController : EntityControllerBase<TPlBayTransfer, TPlBayTransferReadModel, TPlBayTransferCreateModel, TPlBayTransferUpdateModel>
    {
        public TRcBayTransfersController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlBayTransferCreateModel> createValidator, IValidator<TPlBayTransferUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        public class Transfer
        {
            public string year { get; set; }
            public string month { get; set; }

        }
        /// <summary>
        /// 生成倒运报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> ReportExcel()
        {
            MemoryStream memoryStream = await ReportExcelStream();
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = "倒运数据统计.xlsx"
            };
        }

        /// <summary>
        /// 创建倒运报表Excel
        /// </summary>
        /// <returns></returns>
        private async Task<MemoryStream> ReportExcelStream()
        {
            var repo = DataContext.Set<TWhStack>();
            var rc = DataContext.Set<TRcMaterial>();
            var model = await rc.Where(t => t.BayName == "111").FirstOrDefaultAsync();
            var rModel = new Transfer
            {
                year = "2022",
                month = "8",
            };
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate(@"excel/TransferReport.xlsx", rModel);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return memoryStream;
        }


        /// <summary>
        /// 生成0点库存报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> MaterialReportExcel()
        {
            MemoryStream memoryStream = await MaterialReportExcelStream();
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = "0点库存报表统计.xlsx"
            };
        }

        /// <summary>
        /// 创建倒运报表Excel
        /// </summary>
        /// <returns></returns>
        private async Task<MemoryStream> MaterialReportExcelStream()
        {
            var repo = DataContext.Set<TWhStack>();
            var rc = DataContext.Set<TRcMaterial>();
            var model = await rc.Where(t => t.BayName == "111").FirstOrDefaultAsync();
            var rModel = new Transfer
            {
                year = "2022",
                month = "8",
            };
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate(@"excel/MaterialReport.xlsx", rModel);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return memoryStream;
        }


    }
}
