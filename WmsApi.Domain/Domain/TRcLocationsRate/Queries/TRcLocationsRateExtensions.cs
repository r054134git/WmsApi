using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TRcLocationsRate" />.
    /// </summary>
    public static partial class TRcLocationsRateExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="dt">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationsRate> ByDt(this IQueryable<WmsApi.Domain.Entities.TRcLocationsRate> queryable, DateTime dt)
        {
            return queryable.Where(q => q.Dt == dt);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="dt">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcLocationsRate"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcLocationsRate GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcLocationsRate> queryable, string id, DateTime dt)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcLocationsRate> dbSet)
                return dbSet.Find(id, dt);

            return queryable.FirstOrDefault(q => q.Id == id
                && q.Dt == dt);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="dt">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcLocationsRate"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcLocationsRate> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcLocationsRate> queryable, string id, DateTime dt)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcLocationsRate> dbSet)
                return dbSet.FindAsync(id, dt);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.Dt == dt);
            return new ValueTask<WmsApi.Domain.Entities.TRcLocationsRate>(task);
        }

        #endregion

    }
}
