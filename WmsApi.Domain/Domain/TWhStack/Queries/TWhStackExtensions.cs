using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TWhStack" />.
	/// </summary>
	public static partial class TWhStackExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhStack"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TWhStack GetByKey(this IQueryable<WmsApi.Domain.Entities.TWhStack> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TWhStack> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhStack"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TWhStack> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TWhStack> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TWhStack> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TWhStack>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="ownerId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhStack> ByOwnerId(this IQueryable<WmsApi.Domain.Entities.TWhStack> queryable, string ownerId)
        {
            return queryable.Where(q => q.OwnerId == ownerId);
        }

        #endregion

    }
}
