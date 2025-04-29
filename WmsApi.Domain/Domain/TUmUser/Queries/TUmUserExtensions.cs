using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="WmsApi.Domain.Entities.TUmUser" />.
    /// </summary>
    public static partial class TUmUserExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayIdNameList">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TUmUser> ByBayIdNameList(this IQueryable<WmsApi.Domain.Entities.TUmUser> queryable, string bayIdNameList)
        {
            return queryable.Where(q => (q.BayIdNameList == bayIdNameList || (bayIdNameList == null && q.BayIdNameList == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TUmUser"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TUmUser GetByKey(this IQueryable<WmsApi.Domain.Entities.TUmUser> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TUmUser> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TUmUser"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TUmUser> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TUmUser> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TUmUser> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TUmUser>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="roleId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TUmUser> ByRoleId(this IQueryable<WmsApi.Domain.Entities.TUmUser> queryable, string roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="teamId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TUmUser> ByTeamId(this IQueryable<WmsApi.Domain.Entities.TUmUser> queryable, string teamId)
        {
            return queryable.Where(q => q.TeamId == teamId);
        }

        #endregion

    }
}
