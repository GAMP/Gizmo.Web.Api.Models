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
    [Serializable, MessagePackObject]
    public sealed class PagedClassicList<T>(IEnumerable<T> data)
    {
        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; } = data;
    }
}
