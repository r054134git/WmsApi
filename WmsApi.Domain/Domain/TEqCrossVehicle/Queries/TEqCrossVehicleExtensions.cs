using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TEqCrossVehicle" />.
    /// </summary>
    public static partial class TEqCrossVehicleExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="fenceAreaId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqCrossVehicle> ByFenceAreaId(this IQueryable<WmsApi.Domain.Entities.TEqCrossVehicle> queryable, string fenceAreaId)
        {
            return queryable.Where(q => (q.FenceAreaId == fenceAreaId || (fenceAreaId == null && q.FenceAreaId == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TEqCrossVehicle"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TEqCrossVehicle GetByKey(this IQueryable<WmsApi.Domain.Entities.TEqCrossVehicle> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TEqCrossVehicle> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TEqCrossVehicle"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TEqCrossVehicle> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TEqCrossVehicle> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TEqCrossVehicle> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TEqCrossVehicle>(task);
        }

        #endregion

    }
}
