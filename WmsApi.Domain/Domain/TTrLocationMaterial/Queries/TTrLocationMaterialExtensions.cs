using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TTrLocationMaterial" />.
    /// </summary>
    public static partial class TTrLocationMaterialExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="areaCode">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByAreaCode(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string areaCode)
        {
            return queryable.Where(q => q.AreaCode == areaCode);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayCode">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByBayCode(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string bayCode)
        {
            return queryable.Where(q => (q.BayCode == bayCode || (bayCode == null && q.BayCode == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByBayId(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string bayId)
        {
            return queryable.Where(q => q.BayId == bayId);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="bayId">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrLocationMaterial"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrLocationMaterial GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string id, string bayId)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrLocationMaterial> dbSet)
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
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrLocationMaterial"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrLocationMaterial> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string id, string bayId)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrLocationMaterial> dbSet)
                return dbSet.FindAsync(id, bayId);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.BayId == bayId);
            return new ValueTask<WmsApi.Domain.Entities.TTrLocationMaterial>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="loadType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByLoadType(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, int loadType)
        {
            return queryable.Where(q => q.LoadType == loadType);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="locationId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByLocationId(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string locationId)
        {
            return queryable.Where(q => q.LocationId == locationId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="locationName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByLocationName(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string locationName)
        {
            return queryable.Where(q => q.LocationName == locationName);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string materialId)
        {
            return queryable.Where(q => (q.MaterialId == materialId || (materialId == null && q.MaterialId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByMaterialNo(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, string materialNo)
        {
            return queryable.Where(q => (q.MaterialNo == materialNo || (materialNo == null && q.MaterialNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="rowNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByRowNo(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, int? rowNo)
        {
            return queryable.Where(q => (q.RowNo == rowNo || (rowNo == null && q.RowNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="storageType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByStorageType(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, int storageType)
        {
            return queryable.Where(q => q.StorageType == storageType);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="type">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> ByType(this IQueryable<WmsApi.Domain.Entities.TTrLocationMaterial> queryable, int type)
        {
            return queryable.Where(q => q.Type == type);
        }

        #endregion

    }
}
