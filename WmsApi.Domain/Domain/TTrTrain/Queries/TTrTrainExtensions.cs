using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TTrTrain" />.
	/// </summary>
	public static partial class TTrTrainExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="houseId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTrain> ByHouseId(this IQueryable<WmsApi.Domain.Entities.TTrTrain> queryable, string houseId)
        {
            return queryable.Where(q => (q.HouseId == houseId || (houseId == null && q.HouseId == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrTrain"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrTrain GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrTrain> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrTrain> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrTrain"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrTrain> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrTrain> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrTrain> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TTrTrain>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="positionId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTrain> ByPositionId(this IQueryable<WmsApi.Domain.Entities.TTrTrain> queryable, string positionId)
        {
            return queryable.Where(q => (q.PositionId == positionId || (positionId == null && q.PositionId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="trainId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTrain> ByTrainId(this IQueryable<WmsApi.Domain.Entities.TTrTrain> queryable, string trainId)
        {
            return queryable.Where(q => (q.TrainId == trainId || (trainId == null && q.TrainId == null)));
        }

        #endregion

    }
}
