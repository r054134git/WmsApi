using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlTruckLoadList" />.
	/// </summary>
	public static partial class TPlTruckLoadListExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="orderNo">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlTruckLoadList"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlTruckLoadList GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlTruckLoadList> queryable, string id, string orderNo)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlTruckLoadList> dbSet)
                return dbSet.Find(id, orderNo);

            return queryable.FirstOrDefault(q => q.Id == id
                && q.OrderNo == orderNo);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="orderNo">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlTruckLoadList"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlTruckLoadList> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlTruckLoadList> queryable, string id, string orderNo)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlTruckLoadList> dbSet)
                return dbSet.FindAsync(id, orderNo);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.OrderNo == orderNo);
            return new ValueTask<WmsApi.Domain.Entities.TPlTruckLoadList>(task);
        }

        #endregion

    }
}
