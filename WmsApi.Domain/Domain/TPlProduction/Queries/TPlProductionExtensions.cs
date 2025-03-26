using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlProduction" />.
	/// </summary>
	public static partial class TPlProductionExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlProduction"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlProduction GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlProduction> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlProduction> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlProduction"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlProduction> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlProduction> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlProduction> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlProduction>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="nextProcessId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlProduction> ByNextProcessId(this IQueryable<WmsApi.Domain.Entities.TPlProduction> queryable, string nextProcessId)
        {
            return queryable.Where(q => (q.NextProcessId == nextProcessId || (nextProcessId == null && q.NextProcessId == null)));
        }

        #endregion

    }
}
