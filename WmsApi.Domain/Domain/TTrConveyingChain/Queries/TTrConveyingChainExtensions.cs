using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TTrConveyingChain" />.
	/// </summary>
	public static partial class TTrConveyingChainExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="conveyorId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> ByConveyorId(this IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> queryable, string conveyorId)
        {
            return queryable.Where(q => (q.ConveyorId == conveyorId || (conveyorId == null && q.ConveyorId == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrConveyingChain"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrConveyingChain GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrConveyingChain> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrConveyingChain"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrConveyingChain> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrConveyingChain> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TTrConveyingChain>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="locationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> ByLocationId(this IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> queryable, string locationId)
        {
            return queryable.Where(q => (q.LocationId == locationId || (locationId == null && q.LocationId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TTrConveyingChain> queryable, string materialId)
        {
            return queryable.Where(q => (q.MaterialId == materialId || (materialId == null && q.MaterialId == null)));
        }

        #endregion

    }
}
