#nullable enable

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
        /// <param name="meta">Meta data.</param>
        public PagedList(IEnumerable<T> data, PaginationMetadata meta)
        {
            Data = data;
            Meta = meta;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; }

        /// <summary>
        /// The pagination metadata of the current result set.
        /// </summary>
        [Key(1)]
        public PaginationMetadata Meta { get; }

        #endregion
    }
}