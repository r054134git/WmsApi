using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlMaterial" />.
	/// </summary>
	public static partial class TPlMaterialExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="createTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlMaterial> ByCreateTime(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, DateTime createTime)
        {
            return queryable.Where(q => q.CreateTime == createTime);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlMaterial"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlMaterial GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlMaterial> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlMaterial"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlMaterial> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlMaterial> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlMaterial>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="isEnable">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlMaterial> ByIsEnable(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, int isEnable)
        {
            return queryable.Where(q => q.IsEnable == isEnable);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="no">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlMaterial> ByNo(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, string no)
        {
            return queryable.Where(q => q.No == no);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="prepickTransferNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlMaterial> ByPrepickTransferNo(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, string prepickTransferNo)
        {
            return queryable.Where(q => (q.PrepickTransferNo == prepickTransferNo || (prepickTransferNo == null && q.PrepickTransferNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="sourceType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlMaterial> BySourceType(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, int? sourceType)
        {
            return queryable.Where(q => (q.SourceType == sourceType || (sourceType == null && q.SourceType == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="truckLoadListId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlMaterial> ByTruckLoadListId(this IQueryable<WmsApi.Domain.Entities.TPlMaterial> queryable, string truckLoadListId)
        {
            return queryable.Where(q => (q.TruckLoadListId == truckLoadListId || (truckLoadListId == null && q.TruckLoadListId == null)));
        }

        #endregion

    }
}
