using MessagePack;

using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Paged list.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    [Serializable, MessagePackObject]
    public sealed class PagedList<T>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="data">Data.</param>
        public PagedList(IEnumerable<T> data)
        {
            Data = data;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; }

        /// <summary>
        /// Cursor for the request of the next chunk of the records.
        /// </summary>
        [Key(1)]
        public PaginationCursor? NextCursor { get; set; }

        /// <summary>
        /// Cursor for the request of the previous chunk of the records.
        /// </summary>
        [Key(2)]
        public PaginationCursor? PrevCursor { get; set; }

        #endregion
    }
}
