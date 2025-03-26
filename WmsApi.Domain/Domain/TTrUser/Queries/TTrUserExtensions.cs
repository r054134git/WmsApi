using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TTrUser" />.
	/// </summary>
	public static partial class TTrUserExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrUser"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TTrUser GetByKey(this IQueryable<WmsApi.Domain.Entities.TTrUser> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrUser> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TTrUser"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TTrUser> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TTrUser> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TTrUser> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TTrUser>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="shiftId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrUser> ByShiftId(this IQueryable<WmsApi.Domain.Entities.TTrUser> queryable, string shiftId)
        {
            return queryable.Where(q => (q.ShiftId == shiftId || (shiftId == null && q.ShiftId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="teamId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TTrUser> ByTeamId(this IQueryable<WmsApi.Domain.Entities.TTrUser> queryable, string teamId)
        {
            return queryable.Where(q => (q.TeamId == teamId || (teamId == null && q.TeamId == null)));
        }

        #endregion

    }
}
