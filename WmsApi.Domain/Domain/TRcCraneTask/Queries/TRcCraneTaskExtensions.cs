using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TRcCraneTask" />.
	/// </summary>
	public static partial class TRcCraneTaskExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="bayName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByBayName(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string bayName)
        {
            return queryable.Where(q => (q.BayName == bayName || (bayName == null && q.BayName == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="craneName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByCraneName(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string craneName)
        {
            return queryable.Where(q => (q.CraneName == craneName || (craneName == null && q.CraneName == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="endTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByEndTime(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, DateTime? endTime)
        {
            return queryable.Where(q => (q.EndTime == endTime || (endTime == null && q.EndTime == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcCraneTask"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcCraneTask GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcCraneTask> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcCraneTask"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcCraneTask> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcCraneTask> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcCraneTask>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="loadLocationName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByLoadLocationName(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string loadLocationName)
        {
            return queryable.Where(q => (q.LoadLocationName == loadLocationName || (loadLocationName == null && q.LoadLocationName == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="planTypeName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByPlanTypeName(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string planTypeName)
        {
            return queryable.Where(q => (q.PlanTypeName == planTypeName || (planTypeName == null && q.PlanTypeName == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="startTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByStartTime(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, DateTime? startTime)
        {
            return queryable.Where(q => (q.StartTime == startTime || (startTime == null && q.StartTime == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="taskNo">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByTaskNo(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string taskNo)
        {
            return queryable.Where(q => (q.TaskNo == taskNo || (taskNo == null && q.TaskNo == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="teamName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByTeamName(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string teamName)
        {
            return queryable.Where(q => (q.TeamName == teamName || (teamName == null && q.TeamName == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="unloadLocationName">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcCraneTask> ByUnloadLocationName(this IQueryable<WmsApi.Domain.Entities.TRcCraneTask> queryable, string unloadLocationName)
        {
            return queryable.Where(q => (q.UnloadLocationName == unloadLocationName || (unloadLocationName == null && q.UnloadLocationName == null)));
        }

        #endregion

    }
}
