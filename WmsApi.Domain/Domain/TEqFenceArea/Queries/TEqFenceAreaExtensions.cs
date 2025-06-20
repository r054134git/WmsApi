using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TEqFenceArea" />.
	/// </summary>
	public static partial class TEqFenceAreaExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TEqFenceArea"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TEqFenceArea GetByKey(this IQueryable<WmsApi.Domain.Entities.TEqFenceArea> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TEqFenceArea> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TEqFenceArea"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TEqFenceArea> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TEqFenceArea> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TEqFenceArea> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TEqFenceArea>(task);
        }

        #endregion

    }
}
