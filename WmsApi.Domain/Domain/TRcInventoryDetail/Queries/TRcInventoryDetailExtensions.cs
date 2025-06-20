using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TRcInventoryDetail" />.
    /// </summary>
    public static partial class TRcInventoryDetailExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcInventoryDetail"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcInventoryDetail GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcInventoryDetail> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcInventoryDetail> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcInventoryDetail"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcInventoryDetail> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcInventoryDetail> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcInventoryDetail> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcInventoryDetail>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="planId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcInventoryDetail> ByPlanId(this IQueryable<WmsApi.Domain.Entities.TRcInventoryDetail> queryable, string planId)
        {
            return queryable.Where(q => q.PlanId == planId);
        }

        #endregion

    }
}
