using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlCraneTask" />.
	/// </summary>
	public static partial class TPlCraneTaskExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCraneTask> ByBayId(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string bayId)
        {
            return queryable.Where(q => (q.BayId == bayId || (bayId == null && q.BayId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="craneId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCraneTask> ByCraneId(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string craneId)
        {
            return queryable.Where(q => (q.CraneId == craneId || (craneId == null && q.CraneId == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlCraneTask"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlCraneTask GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlCraneTask> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlCraneTask"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlCraneTask> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlCraneTask> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlCraneTask>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="loadLocationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCraneTask> ByLoadLocationId(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string loadLocationId)
        {
            return queryable.Where(q => (q.LoadLocationId == loadLocationId || (loadLocationId == null && q.LoadLocationId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCraneTask> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string materialId)
        {
            return queryable.Where(q => (q.MaterialId == materialId || (materialId == null && q.MaterialId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="ownerId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCraneTask> ByOwnerId(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string ownerId)
        {
            return queryable.Where(q => (q.OwnerId == ownerId || (ownerId == null && q.OwnerId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="unloadLocationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCraneTask> ByUnloadLocationId(this IQueryable<WmsApi.Domain.Entities.TPlCraneTask> queryable, string unloadLocationId)
        {
            return queryable.Where(q => (q.UnloadLocationId == unloadLocationId || (unloadLocationId == null && q.UnloadLocationId == null)));
        }

        #endregion

    }
}
