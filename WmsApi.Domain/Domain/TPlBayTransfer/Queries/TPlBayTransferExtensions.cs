using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TPlBayTransfer" />.
	/// </summary>
	public static partial class TPlBayTransferExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="destBayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> ByDestBayId(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string destBayId)
        {
            return queryable.Where(q => q.DestBayId == destBayId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="fromBayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> ByFromBayId(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string fromBayId)
        {
            return queryable.Where(q => q.FromBayId == fromBayId);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlBayTransfer"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TPlBayTransfer GetByKey(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlBayTransfer> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TPlBayTransfer"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TPlBayTransfer> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TPlBayTransfer> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TPlBayTransfer>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string materialId)
        {
            return queryable.Where(q => (q.MaterialId == materialId || (materialId == null && q.MaterialId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="planTypeId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> ByPlanTypeId(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string planTypeId)
        {
            return queryable.Where(q => q.PlanTypeId == planTypeId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="vehicleTypeId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> ByVehicleTypeId(this IQueryable<WmsApi.Domain.Entities.TPlBayTransfer> queryable, string vehicleTypeId)
        {
            return queryable.Where(q => (q.VehicleTypeId == vehicleTypeId || (vehicleTypeId == null && q.VehicleTypeId == null)));
        }

        #endregion

    }
}
