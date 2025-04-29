using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TRcBay" />.
    /// </summary>
    public static partial class TRcBayExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcBay> ByBayId(this IQueryable<WmsApi.Domain.Entities.TRcBay> queryable, string bayId)
        {
            return queryable.Where(q => q.BayId == bayId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayTransferPlanId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcBay> ByBayTransferPlanId(this IQueryable<WmsApi.Domain.Entities.TRcBay> queryable, string bayTransferPlanId)
        {
            return queryable.Where(q => (q.BayTransferPlanId == bayTransferPlanId || (bayTransferPlanId == null && q.BayTransferPlanId == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcBay"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcBay GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcBay> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcBay> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcBay"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcBay> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcBay> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcBay> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcBay>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcBay> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TRcBay> queryable, string materialId)
        {
            return queryable.Where(q => q.MaterialId == materialId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="planTypeId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcBay> ByPlanTypeId(this IQueryable<WmsApi.Domain.Entities.TRcBay> queryable, string planTypeId)
        {
            return queryable.Where(q => q.PlanTypeId == planTypeId);
        }

        #endregion

    }
}
