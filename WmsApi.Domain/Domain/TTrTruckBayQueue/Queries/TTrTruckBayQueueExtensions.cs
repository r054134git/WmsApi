using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TTrTruckBayQueue" />.
    /// </summary>
    public static partial class TTrTruckBayQueueExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayCode">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> ByBayCode(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, string bayCode)
        {
            return queryable.Where(q => (q.BayCode == bayCode || (bayCode == null && q.BayCode == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="dispatchStepState">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> ByDispatchStepState(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, int? dispatchStepState)
        {
            return queryable.Where(q => (q.DispatchStepState == dispatchStepState || (dispatchStepState == null && q.DispatchStepState == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrTruckBayQueue"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrTruckBayQueue GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrTruckBayQueue> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrTruckBayQueue"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrTruckBayQueue> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrTruckBayQueue> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TTrTruckBayQueue>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="isEnable">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> ByIsEnable(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, int isEnable)
        {
            return queryable.Where(q => q.IsEnable == isEnable);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="mainLoadingNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> ByMainLoadingNo(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, string mainLoadingNo)
        {
            return queryable.Where(q => (q.MainLoadingNo == mainLoadingNo || (mainLoadingNo == null && q.MainLoadingNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="truckNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> ByTruckNo(this IQueryable<WmsApi.Domain.Entities.TTrTruckBayQueue> queryable, string truckNo)
        {
            return queryable.Where(q => (q.TruckNo == truckNo || (truckNo == null && q.TruckNo == null)));
        }

        #endregion

    }
}
