using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlTrainDelivery" />.
	/// </summary>
	public static partial class TPlTrainDeliveryExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="coilNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlTrainDelivery> ByCoilNo(this IQueryable<WmsApi.Domain.Entities.TPlTrainDelivery> queryable, string coilNo)
        {
            return queryable.Where(q => q.CoilNo == coilNo);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlTrainDelivery"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlTrainDelivery GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlTrainDelivery> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlTrainDelivery> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlTrainDelivery"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlTrainDelivery> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlTrainDelivery> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlTrainDelivery> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlTrainDelivery>(task);
        }

        #endregion

    }
}
