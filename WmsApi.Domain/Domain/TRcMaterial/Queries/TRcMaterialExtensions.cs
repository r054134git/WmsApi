using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TRcMaterial" />.
	/// </summary>
	public static partial class TRcMaterialExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="createTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterial> ByCreateTime(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, DateTime createTime)
        {
            return queryable.Where(q => q.CreateTime == createTime);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcMaterial"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcMaterial GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcMaterial> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcMaterial"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcMaterial> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcMaterial> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcMaterial>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="isEnable">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterial> ByIsEnable(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, int isEnable)
        {
            return queryable.Where(q => q.IsEnable == isEnable);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="no">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterial> ByNo(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, string no)
        {
            return queryable.Where(q => q.No == no);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="prepickTransferNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterial> ByPrepickTransferNo(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, string prepickTransferNo)
        {
            return queryable.Where(q => (q.PrepickTransferNo == prepickTransferNo || (prepickTransferNo == null && q.PrepickTransferNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="sourceType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterial> BySourceType(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, int? sourceType)
        {
            return queryable.Where(q => (q.SourceType == sourceType || (sourceType == null && q.SourceType == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="truckLoadListId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterial> ByTruckLoadListId(this IQueryable<WmsApi.Domain.Entities.TRcMaterial> queryable, string truckLoadListId)
        {
            return queryable.Where(q => (q.TruckLoadListId == truckLoadListId || (truckLoadListId == null && q.TruckLoadListId == null)));
        }

        #endregion

    }
}
