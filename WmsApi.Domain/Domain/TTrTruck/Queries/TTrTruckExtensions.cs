using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TTrTruck" />.
	/// </summary>
	public static partial class TTrTruckExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrTruck"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrTruck GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrTruck> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrTruck> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrTruck"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrTruck> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrTruck> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrTruck> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TTrTruck>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="loadBayCodeList">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTruck> ByLoadBayCodeList(this IQueryable<WmsApi.Domain.Entities.TTrTruck> queryable, string loadBayCodeList)
        {
            return queryable.Where(q => (q.LoadBayCodeList == loadBayCodeList || (loadBayCodeList == null && q.LoadBayCodeList == null)));
        }

        #endregion

    }
}
