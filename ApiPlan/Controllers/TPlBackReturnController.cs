using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Wms.Telegram;
using WmsApi;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlBackReturnController : EntityControllerBase<TPlBackReturn, TPlBackReturnReadModel, TPlBackReturnCreateModel, TPlBackReturnUpdateModel>
    {
        public TPlBackReturnController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlBackReturnCreateModel> createValidator, IValidator<TPlBackReturnUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPost("")]
        public override async Task<ActionResult<OperationResult>> Create(TPlBackReturnCreateModel createModel, CancellationToken cancellationToken)
        {
            var userAccount = User.GetUserName();
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }
            SetCreateModelBasic(createModel);

            // validate model
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);

            var trLocationEntity = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == createModel.MaterialNo && t.Type == 2);

            if (trLocationEntity == null)
            {
                return new OperationResult(false, "������Ϣ���ڿ�");
            }

            var retSourceDic = await DataContext.Set<TScDictionary>().FirstOrDefaultAsync(t => t.Key == createModel.RetSource);

            trLocationEntity.LockMark = 1;
            trLocationEntity.LockReason = retSourceDic.Value;

            var plMat = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == trLocationEntity.MaterialNo);
            if (plMat != null)
            {
                plMat.LockMark = 1;
                plMat.LockReason = retSourceDic.Value;
            }

            createModel.BayCode = trLocationEntity.BayCode;
            createModel.ExecState = 1;   //������������ִ��
            createModel.IsRequestCofirm = 0; //Y8��ȷ��
            // create new entity from model
            var entity = Mapper.Map<TPlBackReturn>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TPlBackReturn>()
                .AddAsync(entity, cancellationToken);

            // save to database
            var count = await DataContext
                .SaveChangesAsync(cancellationToken);
            if (count > 0)
            {
                var user = await DataContext.Set<TUmUser>().FirstOrDefaultAsync(t => t.Account == userAccount);
                string userName = string.Empty;
                if (user == null)
                {
                    userAccount = "Y8-Admin";
                    userName = "Y8-Admin";
                }
                else
                {
                    userName = user.Name;
                }
                var mbs = ServiceProvider.GetService<MbsProxy>();
                TeleWMBM05 tele05 = new TeleWMBM05
                {
                    Payload = new CancellingStocksInfo
                    {
                        OperationMark = "N",
                        CoilNo = createModel.MaterialNo,
                        ReStocksDesc = createModel.RetSource,
                        ReStocksReason = createModel.RetReason,
                        ReStocksProcess = createModel.RetType,
                        ReStocksWay = createModel.Mode.ToString(),
                        Operator = userAccount,
                        OperatorName = userName,
                        OperatorTime = entity.CreateTime.ToString("yyyyMMddHHmmss")
                    }
                };
                await mbs.Publish(tele05);
            }
            return operationResult;
        }

        /// <summary>
        /// �˿�ƻ�ɾ��
        /// </summary>
        /// <returns></returns>
        [TokenActionFilter]
        [HttpDelete]
        public override async Task<ActionResult<OperationResult>> Delete([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var repo = DataContext.Set<TPlBackReturn>();
            var idsString = string.Join(",", ids);
            var userAccount = User.GetUserName();

            var retPlan = await repo.FirstOrDefaultAsync(t => t.Id == ids[0]);
            if (retPlan == null)
            {
                return new OperationResult(false, $"�˿�ƻ����ݲ����ڣ�");
            }
            repo.Remove(retPlan);
            var trLocMat = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == retPlan.MaterialNo && t.Type == 2);

            if (trLocMat != null)
            {
                trLocMat.LockMark = 0;
                trLocMat.LockReason = "";
            }

            var plMat = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == trLocMat.MaterialNo);
            if (plMat != null)
            {
                plMat.LockMark = 0;
                plMat.LockReason = "";
            }
            int count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count > 0)
            {
                var user = await DataContext.Set<TUmUser>().FirstOrDefaultAsync(t => t.Account == userAccount);
                var mbs = ServiceProvider.GetService<MbsProxy>();
                TeleWMBM05 tele05 = new TeleWMBM05
                {
                    Payload = new CancellingStocksInfo
                    {
                        OperationMark = "D",
                        CoilNo = retPlan.MaterialNo,
                        ReStocksDesc = retPlan.RetSource,
                        ReStocksReason = retPlan.RetReason,
                        ReStocksProcess = retPlan.RetType,
                        ReStocksWay = retPlan.Mode.ToString(),
                        Operator = userAccount,
                        OperatorName = user.Name,
                        OperatorTime = retPlan.CreateTime.ToString("yyyyMMddHHmmss")
                    }
                };
                await mbs.Publish(tele05);
            }

            return new OperationResult(true, $"�˿�ƻ�����ɾ���ɹ���");
        }

        [HttpGet("")]
        public async Task<ActionResult<OperationResult>> CheckLocation(string retLocation)
        {
            var locMat = await DataContext.Set<TTrLocationMaterial>().
                FirstOrDefaultAsync(t => t.LocationName == retLocation && t.OwnerBussinessName == "P4");
            if (locMat == null)
            {
                return new OperationResult(false, $"�ÿ�λ������");
            }
            if (locMat.IsEnable == 0)
            {
                return new OperationResult(false, $"�ÿ�λ�ѱ�����");
            }
            if (locMat.Type == 2)
            {
                return new OperationResult(false, $"�ÿ�λ���о�");
            }

            return new OperationResult(true, "");
        }

        [HttpGet("")]
        public async Task<ActionResult<OperationResult>> CheckBackLocation(string backLocation)
        {
            string[] busNameArr = new string[] { "P5", "P6", "P8" };
            var locMat = await DataContext.Set<TTrLocationMaterial>().
                FirstOrDefaultAsync(t => t.LocationName == backLocation && busNameArr.Contains(t.OwnerBussinessName));
            if (locMat == null)
            {
                return new OperationResult(false, $"�ÿ�λ������");
            }
            if (locMat.IsEnable == 0)
            {
                return new OperationResult(false, $"�ÿ�λ�ѱ�����");
            }
            if (locMat.Type == 2)
            {
                return new OperationResult(false, $"�ÿ�λ���о�");
            }

            return new OperationResult(true, "");
        }

        [TokenActionFilter]
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Confirm(TPlBackReturnUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var userAccount = User.GetUserName();

            var retPlan = await DataContext.Set<TPlBackReturn>()
                .FirstOrDefaultAsync(t => t.Id == updateModel.Id);
            if (retPlan == null)
            {
                return new OperationResult(false, "���ݲ����ڣ�ȷ��ʧ��");
            }
            if (retPlan.IsRequestCofirm == 1)
            {
                return new OperationResult(false, "Y8��ȷ�ϣ��ظ�ȷ��");
            }
            if (retPlan.IsRequestCofirm != 0)
            {
                return new OperationResult(false, "��ǰ״̬����Y8��ȷ��״̬");
            }
            var locMat = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == retPlan.MaterialNo && t.Type == 2);
            if (locMat == null)
            {
                return new OperationResult(false, "�˿�ľ��ڿ⣬ȷ��ʧ�ܣ�����ϵ�пأ�");
            }
            if (updateModel.RetLocation != null)
            {
                string retBayCode = updateModel.RetLocation.Substring(0, 2);
                if (locMat.BayCode != retBayCode && retPlan.Mode == 1)
                {
                    return new OperationResult(false, "�˿�ľ����˿���P4��λ��������һ����");
                }
                retPlan.IsRequestCofirm = 1;
                retPlan.RetLocation = updateModel.RetLocation;
                retPlan.UpdateTime = DateTime.Now;
                retPlan.UpdateUser = userAccount;
            }
            else
            {
                retPlan.IsRequestCofirm = 1;
                //retPlan.RetLocation = updateModel.RetLocation;
                retPlan.UpdateTime = DateTime.Now;
                retPlan.UpdateUser = userAccount;
            }

            var count = await DataContext.SaveChangesAsync(cancellationToken);
            if (count > 0)
            {
                var user = await DataContext.Set<TUmUser>().FirstOrDefaultAsync(t => t.Account == userAccount);
                string userName = string.Empty;
                if (user == null)
                {
                    userAccount = "Y8-Admin";
                    userName = "Y8-Admin";
                }
                else
                {
                    userName = user.Name;
                }
                var mbs = ServiceProvider.GetService<MbsProxy>();
                TeleWMBM15 tele15 = new TeleWMBM15
                {
                    Payload = new CancellingStocksConfirm
                    {
                        OperationMark = "2",
                        CoilNo = retPlan.MaterialNo,
                        ReStocksReason = retPlan.RetReason,
                        Operator = userAccount,
                        OperatorName = userName,
                        OperatorTime = retPlan.CreateTime.ToString("yyyyMMddHHmmss")
                    }
                };
                await mbs.Publish(tele15);
                await Task.Delay(100);
                TeleWMBM01 tele01 = new TeleWMBM01
                {
                    Payload = new CoilLocationChanged
                    {
                        CoilNo = retPlan.MaterialNo,
                        House = locMat.OwnerBussinessName,
                        Area = locMat.BayCode + locMat.AreaCode,
                        Column = locMat.ColNo.ToString(),
                        Row = locMat.RowNo.ToString(),
                        Tier = locMat.FloorNo.ToString(),
                        ChangeType = "1",
                        Operator = userAccount,
                        OperationTime = DateTime.Now
                    }
                };
                await mbs.Publish(tele01);
                var retDesc = DataContext.Set<TScDictionary>().FirstOrDefault(t => t.Key == retPlan.RetSource).Value;
                var record = new TRcMaterialEvent
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    MaterialId = locMat.MaterialId,
                    MaterialNo = locMat.MaterialNo,
                    Dt = DateTime.Now,
                    OperationType = "�˹�",
                    ContentType = "�˿�-����",
                    FromLocationName = locMat.LocationName,
                    ToLocationName = "",
                    Description = retDesc,
                    FromPosition = $"",
                    ToPosition = $"",
                    Result = "�ɹ�"
                };
                try
                {
                    await DataContext.AddAsync(record);
                    await DataContext.SaveChangesAsync(cancellationToken);
                }
                catch (Exception ex)
                {
                    return new OperationResult(true, "ȷ�ϳɹ�,�������ʧ��");
                }

                return new OperationResult(true, "ȷ�ϳɹ�");
            }
            return new OperationResult(false, "ȷ��ʧ�ܣ�����ϵ����Ա");
        }

        [TokenActionFilter]
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> ConfirmC3(TPlBackReturnUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var userAccount = User.GetUserName();

            var retPlan = await DataContext.Set<TPlBackReturn>()
                .FirstOrDefaultAsync(t => t.Id == updateModel.Id);
            if (retPlan == null)
            {
                return new OperationResult(false, "���ݲ����ڣ�ȷ��ʧ��");
            }
            if (retPlan.IsRequestCofirm == 2)
            {
                return new OperationResult(false, "C3��ȷ�ϣ��ظ�ȷ��");
            }
            if (retPlan.IsRequestCofirm != 1)
            {
                return new OperationResult(false, "��ǰ״̬����C3��ȷ��״̬");
            }
            var locMat = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == retPlan.MaterialNo && t.Type == 2);
            if (locMat == null)
            {
                return new OperationResult(false, "���Ʒ��ľ��ڿ⣬ȷ��ʧ��");
            }

            if (locMat != null)
            {
                locMat.LockMark = 0;
                locMat.LockReason = "";
            }

            var plMat = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == locMat.MaterialNo);
            if (plMat != null)
            {
                plMat.LockMark = 0;
                plMat.LockReason = "";
            }
            if (updateModel.BackLocation != null)
            {
                string retBayCode = updateModel.BackLocation.Substring(0, 2);
                if (locMat.BayCode != retBayCode && retPlan.Mode == 1)
                {
                    return new OperationResult(false, "�˿�ľ���������Ʒ���λ��������һ����");
                }
                retPlan.IsRequestCofirm = 2;
                retPlan.ExecState = 2;
                retPlan.BackLocation = updateModel.BackLocation;
                retPlan.UpdateTime = DateTime.Now;
                retPlan.UpdateUser = userAccount;
            }
            else
            {
                retPlan.IsRequestCofirm = 2;
                retPlan.ExecState = 2;
                //retPlan.BackLocation = updateModel.BackLocation;
                retPlan.UpdateTime = DateTime.Now;
                retPlan.UpdateUser = userAccount;
            }

            var count = await DataContext
                .SaveChangesAsync(cancellationToken);
            //return new OperationResult(true, $"ȷ�ϳɹ� {count}");
            if (count > 0)
            {
                var mbs = ServiceProvider.GetService<MbsProxy>();
                TeleWMBM02 tele02 = new TeleWMBM02
                {
                    Payload = new CoilInfoRequest
                    {
                        CoilNo = retPlan.MaterialNo
                    }
                };
                await mbs.Publish(tele02);
                await Task.Delay(100);
                if (retPlan.Mode == 2) //����������� 
                {
                    TeleWMBM01 tele01 = new TeleWMBM01
                    {
                        Payload = new CoilLocationChanged
                        {
                            CoilNo = retPlan.MaterialNo,
                            House = locMat.OwnerBussinessName,
                            Area = locMat.BayCode + locMat.AreaCode,
                            Column = locMat.ColNo.ToString(),
                            Row = locMat.RowNo.ToString(),
                            Tier = locMat.FloorNo.ToString(),
                            ChangeType = "0",
                            Operator = userAccount,
                            OperationTime = DateTime.Now
                        }
                    };
                    await mbs.Publish(tele01);
                    var retDesc = DataContext.Set<TScDictionary>().FirstOrDefault(t => t.Key == retPlan.RetSource).Value;
                    var record = new TRcMaterialEvent
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        MaterialId = locMat.MaterialId,
                        MaterialNo = locMat.MaterialNo,
                        Dt = DateTime.Now,
                        OperationType = "�˹�",
                        ContentType = "�˿�-���",
                        FromLocationName = "",
                        ToLocationName = locMat.LocationName,
                        Description = retDesc,
                        FromPosition = $"",
                        ToPosition = $"",
                        Result = "�ɹ�"
                    };
                    try
                    {
                        await DataContext.AddAsync(record);
                        await DataContext.SaveChangesAsync(cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        return new OperationResult(true, "ȷ�ϳɹ�,�������ʧ��");
                    }

                }
                return new OperationResult(true, "ȷ�ϳɹ�");
            }
            return new OperationResult(false, "ȷ��ʧ�ܣ�����ϵ����Ա");
        }

        public override async Task<ActionResult<OperationResult>> Update(string id, TPlBackReturnUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TPlBackReturn>()
                .FindAsync(keyValue, cancellationToken);
            if (entity == null)
            {
                return new OperationResult(false, "�����Ѿ����ڣ�����ʧ�ܡ�");
            }

            var trLocationEntity = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == updateModel.MaterialNo && t.Type == 2);
            if (trLocationEntity == null)
            {
                return new OperationResult(false, "�־��ڿ��У�����־�״̬��");
            }

            updateModel.BayCode = trLocationEntity.BayCode;

            // copy updates from model to entity
            Mapper.Map(updateModel, entity);

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "���ݸ��³ɹ���");
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlBackReturnReadModel>>> GetAllBackInfo(string bayCode, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlBackReturn>();
            if (bayCode.IsValidValue())
            {
                var bay = bayCode.Substring(0, 2);
                predicate = predicate.And(t => t.BayCode == bay && t.Mode == 1 && t.IsRequestCofirm == 0 && t.CreateTime>DateTime.Now.AddDays(-15));
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> HoldConfirm(string materialNo, string retLocation, string user, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBay>();
            var repoPlanType = DataContext.Set<TWhPlanType>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var retPlan = await DataContext.Set<TPlBackReturn>().OrderByDescending(t => t.CreateTime)
                .FirstOrDefaultAsync(t => t.MaterialNo == materialNo);
            var planType = repoPlanType.FirstOrDefault(t => t.Name == "�˿⵽��װ��");
            var loadLocation = repoTr.FirstOrDefault(t => t.MaterialNo == materialNo && t.Type == 2);
            var UnloadLocation = repoTr.FirstOrDefault(t => t.LocationName == retLocation);
            if (loadLocation!=null && loadLocation.Type != 2)
            {
                return new OperationResult(false, "���ϲ��ڿ⣬ȷ��ʧ��");
            }
            if (UnloadLocation != null && UnloadLocation.Type != 0)
            {
                return new OperationResult(false, "�˿�Ŀ���λ�о�ȷ��ʧ��");
            }
            if (planType == null)
            {
                return new OperationResult(false, "�˿����Ͳ����ڣ�ȷ��ʧ��");
            }
            if (retPlan == null)
            {
                return new OperationResult(false, "���ݲ����ڣ�ȷ��ʧ��");
            }
            if (retPlan.IsRequestCofirm == 1)
            {
                return new OperationResult(false, "Y8��ȷ�ϣ��ظ�ȷ��");
            }
            if (retPlan.IsRequestCofirm != 0)
            {
                return new OperationResult(false, "��ǰ״̬����Y8��ȷ��״̬");
            }
            
            if (retLocation != null)
            {
                string retBayCode = retLocation.Substring(0, 2);
                if (loadLocation.BayCode != retBayCode && retPlan.Mode == 1)
                {
                    return new OperationResult(false, "�˿�ľ����˿���P4��λ��������һ����");
                }
                retPlan.IsRequestCofirm = 1;
                retPlan.RetLocation = retLocation;
                retPlan.UpdateTime = DateTime.Now;
                retPlan.UpdateUser = user;

                var count = await DataContext.SaveChangesAsync(cancellationToken);
                if (count > 0)
                {
                    var mbs = ServiceProvider.GetService<MbsProxy>();
                    TeleWMBM15 tele15 = new TeleWMBM15
                    {
                        Payload = new CancellingStocksConfirm
                        {
                            OperationMark = "2",
                            CoilNo = retPlan.MaterialNo,
                            ReStocksReason = retPlan.RetReason,
                            Operator = user,
                            OperatorName = user,
                            OperatorTime = retPlan.CreateTime.ToString("yyyyMMddHHmmss")
                        }
                    };
                    await mbs.Publish(tele15);
                    await Task.Delay(100);
                    TeleWMBM01 tele01 = new TeleWMBM01
                    {
                        Payload = new CoilLocationChanged
                        {
                            CoilNo = retPlan.MaterialNo,
                            House = loadLocation.OwnerBussinessName,
                            Area = loadLocation.BayCode + loadLocation.AreaCode,
                            Column = loadLocation.ColNo.ToString(),
                            Row = loadLocation.RowNo.ToString(),
                            Tier = loadLocation.FloorNo.ToString(),
                            ChangeType = "1",
                            Operator = user,
                            OperationTime = DateTime.Now
                        }
                    };
                    await mbs.Publish(tele01);
                    var retDesc = DataContext.Set<TScDictionary>().FirstOrDefault(t => t.Key == retPlan.RetSource).Value;
                    var record = new TRcMaterialEvent
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        MaterialId = loadLocation.MaterialId,
                        MaterialNo = loadLocation.MaterialNo,
                        Dt = DateTime.Now,
                        OperationType = "�˹�",
                        ContentType = "�˿�-����",
                        FromLocationName = loadLocation.LocationName,
                        ToLocationName = UnloadLocation.LocationName,
                        Description = retDesc,
                        FromPosition = $"",
                        ToPosition = $"",
                        Result = "�ɹ�"
                    };
                    var pl = new TPlBay
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        PlanNo = CreatePlanId(),
                        BayId = loadLocation.BayId,
                        BayName = loadLocation.BayCode + "��",
                        MaterialId = loadLocation.MaterialId,
                        MaterialNo = loadLocation.MaterialNo,
                        PlanTypeId = planType.Id,
                        PlanTypeName = planType.Name,
                        LoadLocationId = loadLocation.LocationId,
                        LoadLocationName = loadLocation.LocationName,
                        UnloadLocationId = UnloadLocation.LocationId,
                        UnloadLocationName = UnloadLocation.LocationName,
                        ExecState = 0,
                        PlanState = 0,
                        PriorityOperator = 0,
                        ResolveState = 0,
                        SortIndex = 0,
                        TransferStep = 0,
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = user,
                        UpdateTime = DateTime.Now,
                        UpdateUser = user,

                    };
                    repoPl.Add(pl);
                    try
                    {
                        //await DataContext.AddAsync(record);
                        await DataContext.SaveChangesAsync(cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        return new OperationResult(true, "ȷ�ϳɹ�,�������ʧ��");
                    }

                    return new OperationResult(true, "ȷ�ϳɹ�");
                }
            }
            return new OperationResult(false, "ȷ��ʧ�ܣ�����ϵ�п�");
        }
        /// <summary>
        /// �����ƻ����
        /// </summary>
        /// <returns></returns>
        private string CreatePlanId()
        {
            var repo = DataContext.Set<TWhStack>();
            var sql = "SELECT F_PL_AUTO_CODE('PLAN','WMS') FROM DUAL";
            var number = SqlQuery(sql, (t) => (string)t[0]).First();
            return number;
        }
    }
}
