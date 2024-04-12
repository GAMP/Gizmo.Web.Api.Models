using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination model by classic pagination.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterPaginationClassic
    {
        #region PROPERTIES

        ///<summary>
        /// Gets or sets the page number.
        /// </summary>
        [Key(0)]
        public int Page { get; set; } = 1;

        ///<summary>
        /// Gets or sets the page size.
        /// </summary>
        [Key(1)]
        public int PageSize { get; set; } = 5;

        #endregion
    }
}
