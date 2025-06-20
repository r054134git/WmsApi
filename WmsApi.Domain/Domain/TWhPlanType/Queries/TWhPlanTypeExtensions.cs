using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TWhPlanType" />.
	/// </summary>
	public static partial class TWhPlanTypeExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="destLocationType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhPlanType> ByDestLocationType(this IQueryable<WmsApi.Domain.Entities.TWhPlanType> queryable, int destLocationType)
        {
            return queryable.Where(q => q.DestLocationType == destLocationType);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="fromLocationType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhPlanType> ByFromLocationType(this IQueryable<WmsApi.Domain.Entities.TWhPlanType> queryable, int fromLocationType)
        {
            return queryable.Where(q => q.FromLocationType == fromLocationType);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhPlanType"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TWhPlanType GetByKey(this IQueryable<WmsApi.Domain.Entities.TWhPlanType> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TWhPlanType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TWhPlanType"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TWhPlanType> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TWhPlanType> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TWhPlanType> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TWhPlanType>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="ownerId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhPlanType> ByOwnerId(this IQueryable<WmsApi.Domain.Entities.TWhPlanType> queryable, string ownerId)
        {
            return queryable.Where(q => q.OwnerId == ownerId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="transType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TWhPlanType> ByTransType(this IQueryable<WmsApi.Domain.Entities.TWhPlanType> queryable, int transType)
        {
            return queryable.Where(q => q.TransType == transType);
        }

        #endregion

    }
}
