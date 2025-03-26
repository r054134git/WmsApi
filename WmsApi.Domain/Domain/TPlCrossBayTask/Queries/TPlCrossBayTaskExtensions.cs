using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlCrossBayTask" />.
	/// </summary>
	public static partial class TPlCrossBayTaskExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="destBayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> ByDestBayId(this IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> queryable, string destBayId)
        {
            return queryable.Where(q => q.DestBayId == destBayId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="fromBayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> ByFromBayId(this IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> queryable, string fromBayId)
        {
            return queryable.Where(q => q.FromBayId == fromBayId);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlCrossBayTask"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlCrossBayTask GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlCrossBayTask> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlCrossBayTask"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlCrossBayTask> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlCrossBayTask> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlCrossBayTask>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="vehicleName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> ByVehicleName(this IQueryable<WmsApi.Domain.Entities.TPlCrossBayTask> queryable, string vehicleName)
        {
            return queryable.Where(q => q.VehicleName == vehicleName);
        }

        #endregion

    }
}
