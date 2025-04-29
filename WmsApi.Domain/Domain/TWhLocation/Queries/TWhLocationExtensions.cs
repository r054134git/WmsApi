using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TWhLocation" />.
	/// </summary>
	public static partial class TWhLocationExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayCode">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhLocation> ByBayCode(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, string bayCode)
        {
            return queryable.Where(q => q.BayCode == bayCode);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="floorNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhLocation> ByFloorNo(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, int floorNo)
        {
            return queryable.Where(q => q.FloorNo == floorNo);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhLocation"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TWhLocation GetByKey(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TWhLocation> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhLocation"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TWhLocation> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TWhLocation> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TWhLocation>(task);
        }

        /// <summary>
        /// Gets an instance of <see cref="T:WmsApi.Domain.Entities.TWhLocation"/> by using a unique index.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="name">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhLocation"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TWhLocation GetByName(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        /// <summary>
        /// Gets an instance of <see cref="T:WmsApi.Domain.Entities.TWhLocation"/> by using a unique index.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="name">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhLocation"/> or null if not found.</returns>
        public static Task<WmsApi.Domain.Entities.TWhLocation> GetByNameAsync(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="ownerId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhLocation> ByOwnerId(this IQueryable<WmsApi.Domain.Entities.TWhLocation> queryable, string ownerId)
        {
            return queryable.Where(q => q.OwnerId == ownerId);
        }

        #endregion

    }
}
