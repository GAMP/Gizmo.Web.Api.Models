using System;
using MessagePack;

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
        /// Integer identifier of the record.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Sorting field name (column name) of the record.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Value of the sorting field.
        /// It's set from the cursor data of the previous request.
        /// </summary>
        [Key(2)]
        public string? Value { get; set; }

        /// <summary>
        /// Direction of the scrolling by sorting field.
        /// If true - to the next chunk of the data.
        /// If false - to the previous chunk of the data.
        /// </summary>
        [Key(3)]
        public bool IsForward { get; set; } = true;

        #endregion
    }
}
