using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniExcelLibs;
using System.Data;
using System.Data.Common;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Net;
using WmsApi.Contracts.Models;
using WmsApi.Domain;

namespace WmsApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public abstract class QueryControllerBase<TEntity, TReadModel, TCreateModel, TUpdateModel> : ControllerBase
        where TEntity : class, IHaveIdentifier
        where TReadModel : EntityReadModel
        where TCreateModel : EntityCreateModel
        where TUpdateModel : EntityUpdateModel
    {
        protected QueryControllerBase(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TCreateModel> createValidator, IValidator<TUpdateModel> updateValidator)
        {
            ServiceProvider = serviceProvider;
            DataContext = dataContext;
            Mapper = mapper;
        }

        protected IServiceProvider ServiceProvider { get; set; }

        protected WmspcrContext DataContext { get; }

        protected IMapper Mapper { get; }


        /// <summary>
        /// get function
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TReadModel>>
            Get(string id, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, cancellationToken);

            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpGet("")]
        public virtual async Task<ActionResult<PageResult<TReadModel>>>
            GetPage([FromQuery] PageParam pageParam, CancellationToken cancellationToken)
        {
            var query = GetQueryOrderByIdDesc(null).OrderBy(t => t.Id);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 自定义分页查询
        /// </summary>
        /// <param name="pageParam"></param>
        /// <param name="where">条件语句，如"Name == \"Bpi\" and Age > 50"</param>
        /// <param name="orders">排序语句，如"Name, Age desc"</param>
        /// <param name="cancellationToken"></param>
        /// <returns>分页数据</returns>
        [HttpGet("")]

        public virtual async Task<ActionResult<PageResult<TReadModel>>>
            GetPageByString([FromQuery] PageParam pageParam, string where,
                            string orders, CancellationToken cancellationToken)
        {
            var query = GetQueryByString(where, orders);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 自定义分页查询
        /// </summary>
        /// <param name="pageParam"></param>
        /// <param name="where">条件语句，如"Name == \"Bpi\" and Age > 50"</param>
        /// <param name="orders">排序语句，如"Name, Age desc"</param>
        /// <param name="cancellationToken"></param>
        /// <returns>分页数据</returns>
        [HttpGet("")]

        public virtual async Task<ActionResult<PageResult<TReadModel>>>
            GetListByString(string where, string orders, CancellationToken cancellationToken)
        {
            where = WebUtility.UrlDecode(where);
            var query = GetQueryByString(where, orders);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 生成报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public virtual async Task<ActionResult> CreateReportExcel(string where, string orders, string reportName, CancellationToken cancellationToken)
        {
            where = WebUtility.UrlDecode(where);
            reportName = WebUtility.UrlDecode(reportName);
            var query = GetQueryByString(where, orders);
            var listResult = await QueryListModel(query, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }

        [HttpGet("")]
        [TokenActionFilter]
        public virtual async Task<ActionResult<PageResult<TReadModel>>>
            GetList(CancellationToken cancellationToken)
        {
            var query = GetQueryOrderByIdDesc(null);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        protected virtual async Task<TReadModel> ReadModel(string id, CancellationToken cancellationToken = default)
        {
            var model = await DataContext
                .Set<TEntity>()
                .AsNoTracking()
                .Where(p => p.Id == id)
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);

            return model;
        }

        protected virtual async Task<TReadModel> ReadModel(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            var model = await DataContext
                .Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);

            return model;
        }

        protected virtual async Task<TReadModel> ReadModel(IQueryable<TEntity> query, CancellationToken cancellationToken = default)
        {
            var model = await query
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);

            return model;
        }

        protected virtual IQueryable<TEntity> GetQueryOrderByIdDesc(
            Expression<Func<TEntity, bool>> predicate = null)
        {
            var dbSet = DataContext.Set<TEntity>();

            var query = dbSet.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Id);
            }

            return query;
        }

        protected virtual IQueryable<TEntity> GetQueryByString(string where, string orders)
        {
            var dbSet = DataContext.Set<TEntity>();

            var query = dbSet.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }

            return query;
        }

        protected virtual IQueryable<TEntity> GetQueryOrderByIdAsc(
            Expression<Func<TEntity, bool>> predicate = null)
        {
            var dbSet = DataContext.Set<TEntity>();

            var query = dbSet.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderBy(t => t.Id);
            }

            return query;
        }

        protected virtual IQueryable<TEntity> GetQueryCustomOrder(
            Expression<Func<TEntity, bool>> predicate = null,
            string[] orders = null)
        {
            var dbSet = DataContext.Set<TEntity>();

            var query = dbSet.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orders == null || !orders.Any())
            {
                query = query.OrderBy(t => t.Id);
            }
            else
            {
                foreach (var order in orders)
                {
                    query = query.OrderBy(order);
                }
            }

            return query;
        }

        protected virtual IQueryable<TEntity> GetQueryWithNoneOrder(
            Expression<Func<TEntity, bool>> predicate = null)
        {
            var dbSet = DataContext.Set<TEntity>();

            var query = dbSet.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query;
        }

        protected virtual async Task<PageResult<TReadModel>> QueryListModel(
            IQueryable<TEntity> query,
            CancellationToken cancellationToken = default, int queryCount = 10000)
        {
            var total = query.Count();

            query = query.Take(queryCount);

            var results = await query
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new PageResult<TReadModel>
            {
                Data = results,
                Success = true,
                Total = total
            };
        }

        protected virtual async Task<PageResult<TReadModel>> QueryPageModel(
            IQueryable<TEntity> query,
            PageParam pageParam = null,
            CancellationToken cancellationToken = default)
        {
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
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new PageResult<TReadModel>
            {
                Data = results,
                Success = true,
                Total = total
            };
        }
        protected virtual string GetPrimaryId()
        {
            return "";
        }

        protected virtual List<T> SqlQuery<T>(string sql, Func<DbDataReader, T> map)
        {
            using var command = DataContext.Database.GetDbConnection().CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            DataContext.Database.OpenConnection();
            using var result = command.ExecuteReader();
            var entities = new List<T>();
            while (result.Read())
            {
                entities.Add(map(result));
            }
            return entities;
        }
    }
}