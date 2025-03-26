using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlBay" />.
	/// </summary>
	public static partial class TPlBayExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBay> ByBayId(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string bayId)
        {
            return queryable.Where(q => q.BayId == bayId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayTransferPlanId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBay> ByBayTransferPlanId(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string bayTransferPlanId)
        {
            return queryable.Where(q => (q.BayTransferPlanId == bayTransferPlanId || (bayTransferPlanId == null && q.BayTransferPlanId == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlBay"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlBay GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlBay> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlBay"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlBay> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlBay> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlBay>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="loadLocationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBay> ByLoadLocationId(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string loadLocationId)
        {
            return queryable.Where(q => (q.LoadLocationId == loadLocationId || (loadLocationId == null && q.LoadLocationId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBay> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string materialId)
        {
            return queryable.Where(q => q.MaterialId == materialId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="planTypeId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBay> ByPlanTypeId(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string planTypeId)
        {
            return queryable.Where(q => q.PlanTypeId == planTypeId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="unloadLocationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBay> ByUnloadLocationId(this IQueryable<WmsApi.Domain.Entities.TPlBay> queryable, string unloadLocationId)
        {
            return queryable.Where(q => (q.UnloadLocationId == unloadLocationId || (unloadLocationId == null && q.UnloadLocationId == null)));
        }

        #endregion

    }
}
