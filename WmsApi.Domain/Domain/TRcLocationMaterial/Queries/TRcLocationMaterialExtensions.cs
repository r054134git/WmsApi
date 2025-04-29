using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TRcLocationMaterial" />.
    /// </summary>
    public static partial class TRcLocationMaterialExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayCode">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByBayCode(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string bayCode)
        {
            return queryable.Where(q => (q.BayCode == bayCode || (bayCode == null && q.BayCode == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByBayId(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string bayId)
        {
            return queryable.Where(q => q.BayId == bayId);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcLocationMaterial"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcLocationMaterial GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string id, string bayId)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcLocationMaterial> dbSet)
                return dbSet.Find(id, bayId);

            return queryable.FirstOrDefault(q => q.Id == id
                && q.BayId == bayId);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcLocationMaterial"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcLocationMaterial> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string id, string bayId)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcLocationMaterial> dbSet)
                return dbSet.FindAsync(id, bayId);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.BayId == bayId);
            return new ValueTask<WmsApi.Domain.Entities.TRcLocationMaterial>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="loadType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByLoadType(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, int loadType)
        {
            return queryable.Where(q => q.LoadType == loadType);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="locationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByLocationId(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string locationId)
        {
            return queryable.Where(q => q.LocationId == locationId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string materialId)
        {
            return queryable.Where(q => (q.MaterialId == materialId || (materialId == null && q.MaterialId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByMaterialNo(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, string materialNo)
        {
            return queryable.Where(q => (q.MaterialNo == materialNo || (materialNo == null && q.MaterialNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="shiftEndTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByShiftEndTime(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, DateTime? shiftEndTime)
        {
            return queryable.Where(q => (q.ShiftEndTime == shiftEndTime || (shiftEndTime == null && q.ShiftEndTime == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="shiftStratTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByShiftStratTime(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, DateTime? shiftStratTime)
        {
            return queryable.Where(q => (q.ShiftStratTime == shiftStratTime || (shiftStratTime == null && q.ShiftStratTime == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="storageType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByStorageType(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, int storageType)
        {
            return queryable.Where(q => q.StorageType == storageType);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="type">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> ByType(this IQueryable<WmsApi.Domain.Entities.TRcLocationMaterial> queryable, int type)
        {
            return queryable.Where(q => q.Type == type);
        }

        #endregion

    }
}
