using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TScClient" />.
	/// </summary>
	public static partial class TScClientExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TScClient"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TScClient GetByKey(this IQueryable<WmsApi.Domain.Entities.TScClient> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TScClient> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TScClient"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TScClient> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TScClient> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TScClient> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TScClient>(task);
        }

        #endregion

    }
}
