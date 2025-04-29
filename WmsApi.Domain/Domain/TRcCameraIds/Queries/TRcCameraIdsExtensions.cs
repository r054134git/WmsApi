using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TRcCameraIds" />.
    /// </summary>
    public static partial class TRcCameraIdsExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCameraIds> ByBayName(this IQueryable<WmsApi.Domain.Entities.TRcCameraIds> queryable, string bayName)
        {
            return queryable.Where(q => (q.BayName == bayName || (bayName == null && q.BayName == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="createTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCameraIds> ByCreateTime(this IQueryable<WmsApi.Domain.Entities.TRcCameraIds> queryable, DateTime createTime)
        {
            return queryable.Where(q => q.CreateTime == createTime);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcCameraIds"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcCameraIds GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcCameraIds> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcCameraIds> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcCameraIds"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcCameraIds> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcCameraIds> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcCameraIds> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcCameraIds>(task);
        }

        #endregion

    }
}
