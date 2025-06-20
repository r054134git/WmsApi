using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TRcTelegram" />.
	/// </summary>
	public static partial class TRcTelegramExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcTelegram"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TRcTelegram GetByKey(this IQueryable<WmsApi.Domain.Entities.TRcTelegram> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcTelegram> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TRcTelegram"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TRcTelegram> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TRcTelegram> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TRcTelegram> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TRcTelegram>(task);
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="telegramId">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcTelegram> ByTelegramId(this IQueryable<WmsApi.Domain.Entities.TRcTelegram> queryable, string telegramId)
        {
            return queryable.Where(q => (q.TelegramId == telegramId || (telegramId == null && q.TelegramId == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="telegramTime">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TRcTelegram> ByTelegramTime(this IQueryable<WmsApi.Domain.Entities.TRcTelegram> queryable, DateTime? telegramTime)
        {
            return queryable.Where(q => (q.TelegramTime == telegramTime || (telegramTime == null && q.TelegramTime == null)));
        }

        #endregion

    }
}
