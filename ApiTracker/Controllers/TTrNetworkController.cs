using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Data;
using Cds.Contracts;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using ApiTracker;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("tracker/[controller]/[action]")]
	public class TTrNetworkController : EntityControllerBase<TTrNetwork, TTrNetworkReadModel, TTrNetworkCreateModel, TTrNetworkUpdateModel>
	{
		public TTrNetworkController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrNetworkCreateModel> createValidator, IValidator<TTrNetworkUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}


        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrNetworkReadModel>>> GetQueryList([FromQuery]int[] isConnected, [FromQuery] int[] isEnable, CancellationToken cancellationToken)
        {
            //await  UpdateState(cancellationToken);

            var dbSet = DataContext.Set<TTrNetwork>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrNetwork>();

            if (isConnected != null && isConnected.Length > 0) {
                predicate.And(t => isConnected.Contains(t.IsConnected));
            }
            if (isEnable != null && isEnable.Length > 0)
            {
                predicate.And(t => isEnable.Contains(t.IsEnable));
            }
            query = query.Where(predicate).OrderBy(t => t.Sort);  
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task UpdateState(CancellationToken cancellationToken)
        {
            var dbSet = DataContext.Set<TTrNetwork>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TTrNetwork>();

            query = query.Where(predicate).OrderBy(t => t.Sort);
            var listResult =  await query.ToListAsync(cancellationToken);
            foreach (var item in listResult)
            {
                if (item.IpAddress != "1" && item.IpAddress != "") { 
                var trModel = dbSet.Where(t => t.Id == item.Id).FirstOrDefault();
                var ipState = StatusQuery(item.IpAddress);
                trModel.IsConnected = ipState == true ? 1 : 0;
                }            
            }
            await DataContext.SaveChangesAsync(cancellationToken);
        }

        private bool StatusQuery(string ip)
        {
            bool message = false;
            Ping p = new ();
            try
            {
                PingReply r = p.Send(ip);
                if (r.Status == IPStatus.Success)
                {
                    message = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return message;
        }

        /// <summary>
        /// ÷ÿ∆Ùmoxa
        /// </summary>
        [HttpPost("")]
        public async Task<bool> RebootMoxa([FromQuery] string name, [FromQuery] string ip, CancellationToken cancellationToken)
        {       
            if (name != null && ip != "")
            {
                var mbs = ServiceProvider.GetService<MbsProxy>();
                var payLoad = new NetWorkMoxaReboot()
                {
                    MoxaName = name,
                   MoxaIp = ip,
                };
                await mbs.Publish(payLoad);
            }
            return true;
        }

        /// <summary>
        /// ÷ÿ∆Ù∆Ω…®
        /// </summary>
        [HttpPost("")]
        public Task<bool> RebootFlatScan([FromQuery] string ip, CancellationToken cancellationToken)
        {
            int port = 5153;
            String xmlFilePath = "flatscan.xml";
            ClientSocket clientSocket = new();
            clientSocket.ConnectToServer(ip, port);
            var fileByte = FileTOByte(xmlFilePath);
            clientSocket.SendMSGToServer(fileByte);
            return Task.FromResult(true);
        }
        private static byte[] FileTOByte(string path)
        {
            FileStream fs = new(path, FileMode.Open, FileAccess.Read);
            byte[] infbytes = new byte[(int)fs.Length];
            fs.Read(infbytes, 0, infbytes.Length);
            fs.Close();
            return infbytes;
        }

    }
}
