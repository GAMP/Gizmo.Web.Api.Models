#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination metadata.
    /// </summary>
    [MessagePackObject]
    public sealed class PaginationMetadata
    {
        #region PROPERTIES

        /// <summary>
        /// The id of the record to be used as a cursor to get the next page.
        /// </summary>
        [Key(0)]
        public int NextCursor { get; set; }

        /// <summary>
        /// The id of the record to be used as a cursor to get the previous page.
        /// </summary>
        [Key(1)]
        public int PreviousCursor { get; set; }

        #endregion
    }
}