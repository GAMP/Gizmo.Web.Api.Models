using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination cursor for the data scrolling.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaginationCursor
    {
        #region PROPERTIES

        /// <summary>
        /// Identifier of the record.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }
        
        /// <summary>
        /// Sorting field name of the record.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;
        
        /// <summary>
        /// Value of the sorting field.
        /// </summary>
        [Key(2)]
        public string? Value { get; set; }
        
        /// <summary>
        /// Direction of the scrolling by sorting field.
        /// </summary>
        [Key(3)]
        public bool IsForward { get; set; } = true;

        #endregion
    }
}
