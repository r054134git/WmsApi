using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TRcMaterialEventMigrate" />.
    /// </summary>
    public static partial class TRcMaterialEventMigrateExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="contentType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> ByContentType(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, string contentType)
        {
            return queryable.Where(q => q.ContentType == contentType);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="dt">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> ByDt(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, DateTime dt)
        {
            return queryable.Where(q => q.Dt == dt);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcMaterialEventMigrate"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcMaterialEventMigrate GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcMaterialEventMigrate> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcMaterialEventMigrate"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcMaterialEventMigrate> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcMaterialEventMigrate> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcMaterialEventMigrate>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> ByMaterialId(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, string materialId)
        {
            return queryable.Where(q => q.MaterialId == materialId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="materialNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> ByMaterialNo(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, string materialNo)
        {
            return queryable.Where(q => (q.MaterialNo == materialNo || (materialNo == null && q.MaterialNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="operationType">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> ByOperationType(this IQueryable<WmsApi.Domain.Entities.TRcMaterialEventMigrate> queryable, string operationType)
        {
            return queryable.Where(q => q.OperationType == operationType);
        }

        #endregion

    }
}
