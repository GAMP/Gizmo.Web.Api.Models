using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Model for the classic paginated data.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    /// <exception cref="DivideByZeroException">Thrown when page size is zero.</exception>"
    [Serializable, MessagePackObject]
    public sealed class PagedListClassic<T>
    {
        /// <summary>
        /// Creates new paged list.
        /// </summary>
        /// <param name="data">Results.</param>
        /// <param name="totalItems">Total items.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>Paged list result.</returns>
        public static PagedListClassic<T> Create(IEnumerable<T> data, int totalItems, int pageSize)
        {
            return new PagedListClassic<T>
            {
                Data = data,
                TotalItems = totalItems,
                TotalPages = pageSize <= 0 ? 0 : totalItems / pageSize + (totalItems % pageSize == 0 ? 0 : 1)
            };
        }

        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; init; } = Enumerable.Empty<T>();

        /// <summary>
        /// The total number of items.
        /// </summary>
        [Key(1)]
        public int TotalItems { get; init; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [Key(2)]
        public int TotalPages { get; init; }
    }
}
