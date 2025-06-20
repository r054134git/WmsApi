using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Queries
{
	/// <summary>
	/// Query extensions for entity <see cref="Entities.TEqTrain" />.
	/// </summary>
	public static partial class TEqTrainExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car10Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar10Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car10Id)
        {
            return queryable.Where(q => (q.Car10Id == car10Id || (car10Id == null && q.Car10Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car11Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar11Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car11Id)
        {
            return queryable.Where(q => (q.Car11Id == car11Id || (car11Id == null && q.Car11Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car12Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar12Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car12Id)
        {
            return queryable.Where(q => (q.Car12Id == car12Id || (car12Id == null && q.Car12Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car13Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar13Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car13Id)
        {
            return queryable.Where(q => (q.Car13Id == car13Id || (car13Id == null && q.Car13Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car14Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar14Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car14Id)
        {
            return queryable.Where(q => (q.Car14Id == car14Id || (car14Id == null && q.Car14Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car15Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar15Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car15Id)
        {
            return queryable.Where(q => (q.Car15Id == car15Id || (car15Id == null && q.Car15Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car1Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar1Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car1Id)
        {
            return queryable.Where(q => (q.Car1Id == car1Id || (car1Id == null && q.Car1Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car2Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar2Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car2Id)
        {
            return queryable.Where(q => (q.Car2Id == car2Id || (car2Id == null && q.Car2Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car3Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar3Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car3Id)
        {
            return queryable.Where(q => (q.Car3Id == car3Id || (car3Id == null && q.Car3Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car4Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar4Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car4Id)
        {
            return queryable.Where(q => (q.Car4Id == car4Id || (car4Id == null && q.Car4Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car5Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar5Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car5Id)
        {
            return queryable.Where(q => (q.Car5Id == car5Id || (car5Id == null && q.Car5Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car6Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar6Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car6Id)
        {
            return queryable.Where(q => (q.Car6Id == car6Id || (car6Id == null && q.Car6Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car7Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar7Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car7Id)
        {
            return queryable.Where(q => (q.Car7Id == car7Id || (car7Id == null && q.Car7Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car8Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar8Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car8Id)
        {
            return queryable.Where(q => (q.Car8Id == car8Id || (car8Id == null && q.Car8Id == null)));
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="car9Id">The value to filter by.</param>
        /// <returns>An <see cref="T: System.Linq.IQueryable`1" /> that contains elements from the input sequence that satisfy the condition specified.</returns>
        public static IQueryable<WmsApi.Domain.Entities.TEqTrain> ByCar9Id(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string car9Id)
        {
            return queryable.Where(q => (q.Car9Id == car9Id || (car9Id == null && q.Car9Id == null)));
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TEqTrain"/> or null if not found.</returns>
        public static WmsApi.Domain.Entities.TEqTrain GetByKey(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TEqTrain> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:WmsApi.Domain.Entities.TEqTrain"/> or null if not found.</returns>
        public static ValueTask<WmsApi.Domain.Entities.TEqTrain> GetByKeyAsync(this IQueryable<WmsApi.Domain.Entities.TEqTrain> queryable, string id)
        {
            if (queryable is DbSet<WmsApi.Domain.Entities.TEqTrain> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<WmsApi.Domain.Entities.TEqTrain>(task);
        }

        #endregion

    }
}
