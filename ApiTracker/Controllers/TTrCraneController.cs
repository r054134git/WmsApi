using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Security.Cryptography;
using Wms.Telegram;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using Ucp.Contracts;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("tracker/[controller]/[action]")]
	public class TTrCraneController : EntityControllerBase<TTrCrane, TTrCraneReadModel, TTrCraneCreateModel, TTrCraneUpdateModel>
	{
		public TTrCraneController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrCraneCreateModel> createValidator, IValidator<TTrCraneUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

		/// <summary>
		/// ������ȡ�����г�����
		/// </summary>
		/// <param name="bayId"></param>
		/// <param name="craneId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<PageResult<TTrCraneReadModel>>> GetCraneData(string bayId,string craneId, CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TTrCrane>();
			if (bayId.IsValidValue())
			{
				predicate = predicate.And(t =>t.BayId == bayId);
			}
			var query = GetQueryOrderByIdDesc(predicate);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}

		/// <summary>
		/// �ֳֻ�ȡ�����г�����
		/// </summary>
		/// <param name="craneId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<TTrCraneReadModel>> GetCraneDetail(string craneId, CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TTrCrane>();
			if (craneId.IsValidValue())
			{
				predicate = predicate.And(t => t.CraneId == craneId);
			}
			var query = GetQueryOrderByIdDesc(predicate);
			var listResult = await ReadModel(query, cancellationToken);

			return Ok(listResult);
		}

		/// <summary>
		/// ��ȡ�г��б�
		/// </summary>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<PageResult<TTrCraneReadModel>>> GetCranes(string bayId, CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TTrCrane>();
			if (bayId.IsValidValue())
			{
				predicate = predicate.And(t => t.BayId == bayId);
			}
			var query = GetQueryOrderByIdDesc(predicate);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}

		/// <summary>
		/// �����г�����״̬
		/// </summary>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<OperationResult>> UpdateCraneRunning(string craneName, int mode,string user)
        {
			var trRepo =await DataContext.Set<TTrCrane>().FirstOrDefaultAsync(t => t.CraneName == craneName);
			var repoLog = DataContext.Set<TRcLog>();
			var mbs= ServiceProvider.GetService<MbsProxy>();
			var key = new Key(trRepo.CraneId, trRepo.CraneName, 0);
			if (trRepo.OpMode == 1)
            {
				return new OperationResult(false, "�г����Զ�ģʽ������ʧ��");
            }
			else if (trRepo.OpMode == 3)
			{
				var cmd = new CraneRunningModeCommand
				{
					CraneId = key,
					RunningMode = (CraneRunningModes)mode

				};
				await mbs.Publish(cmd);

				if (mode==0)
                {
					var log = new TRcLog
					{
						Id = IdWorkerGenerator.Instance.NextId().ToString(),
						Dt = DateTime.Now,
						Source = "API",
						EventNo = "1000",
						WarningLevel = "INFO",
						Message = $"�ֳֻ��û�{user}������{key.Name}"
					};
					repoLog.Add(log);
					await DataContext.SaveChangesAsync();
					return new OperationResult(true, "�г��Զ�����");
				}
				else if(mode == 1)
				{
					var log = new TRcLog
					{
						Id = IdWorkerGenerator.Instance.NextId().ToString(),
						Dt = DateTime.Now,
						Source = "API",
						EventNo = "1000",
						WarningLevel = "INFO",
						Message = $"�ֳֻ��û�{user}��ͣ��{key.Name}"
					};
					repoLog.Add(log);
					await DataContext.SaveChangesAsync();
					return new OperationResult(true, "�г�����ͣ");
                }
            };
			return Ok(new OperationResult(false, "����ʧ��"));
        }

        /// <summary>
        /// �����г�����ģʽ
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
		public async Task<ActionResult<OperationResult>> UpdateCraneOpMode(string craneName, int mode, string user)
		{
			var trRepo = await DataContext.Set<TTrCrane>().FirstOrDefaultAsync(t => t.CraneName == craneName);
			var repoLog = DataContext.Set<TRcLog>();
			var mbs = ServiceProvider.GetService<MbsProxy>();
			var key = new Key(trRepo.CraneId, trRepo.CraneName, 0);
			if (mode == 3 && trRepo.OpMode == 3)
			{
				return new OperationResult(false, "�г������Զ�ģʽ");
			}
			if (mode == 1 && trRepo.OpMode == 1)
            {
				return new OperationResult(false, "�г������ֶ�ģʽ");
			}
			else
			{
				var cmd = new CraneOpModeCommand
				{
					CraneId = key,
					OpMode = (CraneOpModes)mode
				};
				await mbs.Publish(cmd);

				if (mode == 3)
				{
					var log = new TRcLog
					{
						Id = IdWorkerGenerator.Instance.NextId().ToString(),
						Dt = DateTime.Now,
						Source = "API",
						EventNo = "1000",
						WarningLevel = "INFO",
						Message = $"�ֳֻ�{user}�û��л�{key.Name}Ϊ�Զ�ģʽ"
					};
					repoLog.Add(log);
					await DataContext.SaveChangesAsync();
					return new OperationResult(true, "�ɹ��л��Զ�ģʽ");
				}
				else if (mode == 1)
				{
					var log = new TRcLog
					{
						Id = IdWorkerGenerator.Instance.NextId().ToString(),
						Dt = DateTime.Now,
						Source = "API",
						EventNo = "1000",
						WarningLevel = "INFO",
						Message = $"�ֳֻ�{user}�û��л�{key.Name}Ϊ�ֶ�ģʽ"
					};
					repoLog.Add(log);
					await DataContext.SaveChangesAsync();
					return new OperationResult(true, "�ɹ��л��ֶ�ģʽ");
				}
			};
			return Ok(new OperationResult(false, "����ʧ��"));
		}

		/// <summary>
		/// ��ȡ�г�����״̬
		/// </summary>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<TTrLocationMaterialReadModel>> GetCraneCoilState(string craneId, StackTypes storeageType, CancellationToken cancellationToken)
		{
			var craneModel = DataContext.Set<TTrCrane>();
			var trModel = DataContext.Set<TTrLocationMaterial>();
			var crane = craneModel.Where(t => t.CraneId == craneId).FirstOrDefault();
			if (crane != null && !string.IsNullOrWhiteSpace(crane.MaterialId))
			{
				var result =await trModel.Where(t => t.MaterialId == crane.MaterialId).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefaultAsync();
				return result;
			}
			return null;
		}

        /// <summary>
        /// �г���¼
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult<string>>> Login(string craneName, string account, string password, CancellationToken cancellationToken)
        {
            var umUserRepo = DataContext.Set<TUmUser>();
            var trUserRepo = DataContext.Set<TTrUser>();

            var umUser = umUserRepo.FirstOrDefault(item => item.Account == account);
            if (umUser != null)
            {
                var trUser = trUserRepo.FirstOrDefault(t => t.LoginUserId == umUser.Id && t.ClientName != craneName);
                if (trUser != null)
                {
                    return new OperationResult<string>(false, $"���˺�{account}����{trUser.ClientName}��¼", string.Empty);
                }
                SHA256 s256 = SHA256.Create();
                byte[] bs = s256.ComputeHash(Encoding.Default.GetBytes(password));
                s256.Clear();
                var passwordSha256 = Convert.ToBase64String(bs);
                if (umUser.Password == password)
                {
                    var uTrUser = trUserRepo.FirstOrDefault(t => t.ClientName == craneName);
                    if (uTrUser != null)
                    {
                        uTrUser.LoginUserId = umUser.Id;
                        uTrUser.TeamId = umUser.TeamId;
                        await DataContext.SaveChangesAsync();
                    }

                    return new OperationResult<string>(true, string.Empty, umUser.Id);
                }
                else
                {
                    return new OperationResult<string>(false, "���벻��ȷ�����������롣", string.Empty);
                }
            }
            return new OperationResult<string>(false, string.Empty, "�û��˺Ų����ڣ����������롣");
        }

        [HttpPut("")]
        public async Task<ActionResult<bool>> Logout(string craneName, CancellationToken cancellationToken)
        {
            var trUserRepo = DataContext.Set<TTrUser>();
            var uTrUser = trUserRepo.FirstOrDefault(t => t.ClientName == craneName);
            if (uTrUser != null)
            {
                uTrUser.LoginUserId = null;
                uTrUser.TeamId = null;
                await DataContext.SaveChangesAsync();
            }
            return true;
        }

		[HttpPost("")]
		public async Task<ActionResult<string>> SendOpModeCommand(string craneId, int opModeValue, CancellationToken cancellationToken)
		{
			var proxy = ServiceProvider.GetService<MbsProxy>();
			if (proxy != null)
			{
				var trCraneRepo = DataContext.Set<TTrCrane>();
				var crane = trCraneRepo.Where(t => t.CraneId == craneId).FirstOrDefault();
				if (crane != null)
				{
					var command = new CraneOpModeCommand()
					{
						CraneId = new Ucp.Contracts.Key(craneId, crane.CraneName, 0),
						OpMode = (CraneOpModes)opModeValue,
					};

					await proxy.Publish(command);
					return Ok($"{crane.CraneName}�Ĳ���ģʽ{command.OpMode}���ͳɹ�");
				}
				return Ok($"�г�Id {craneId}������");
			}
			return Ok("Proxy������");
		}
	}
}
