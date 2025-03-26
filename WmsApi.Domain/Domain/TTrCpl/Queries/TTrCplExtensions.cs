using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TTrCpl" />.
	/// </summary>
	public static partial class TTrCplExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrCpl"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrCpl GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrCpl> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrCpl> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrCpl"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrCpl> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrCpl> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrCpl> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TTrCpl>(task);
        }

        #endregion

    }
}
