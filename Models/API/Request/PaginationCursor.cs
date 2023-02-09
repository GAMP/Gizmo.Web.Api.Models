using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination cursor.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaginationCursor
    {
        #region PROPERTIES

        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public object? Value { get; set; }
        [Key(3)]
        public bool IsForward { get; set; }

        #endregion
    }
}
