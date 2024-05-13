using System;
using System.Collections.Generic;

using MessagePack;

namespace Gizmo.Web.Api.Models
{

    /// <summary>
    /// Model for the classic paginated data.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    /// <param name="data">Data.</param>
    /// <param name="totalItems">Total number of items.</param>
    /// <param name="pageSize"> Page size from the filter.</param>
    /// <exception cref="DivideByZeroException">Thrown when page size is zero.</exception>"
    [Serializable, MessagePackObject]
    public sealed class PagedListClassic<T>(IEnumerable<T> data, int totalItems, int pageSize)
    {
        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; } = data;

        /// <summary>
        /// The total number of items.
        /// </summary>
        [Key(1)]
        public int TotalItems { get; } = totalItems;

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [Key(2)]
        public int TotalPages { get; } = pageSize <=0 ? 0 : totalItems / pageSize + (totalItems % pageSize == 0 ? 0 : 1);
    }
}
