using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note count.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserNoteCountModel
    {
        #region PROPERTIES

        /// <summary>
        /// Number of notes with purple severity.
        /// </summary>
        [MessagePack.Key(0)]
        public int SeverityPurpleCount { get; init; }
        
        /// <summary>
        /// Number of notes with orange severity.
        /// </summary>
        [MessagePack.Key(1)]
        public int SeverityOrangeCount { get; init; }

        /// <summary>
        /// Number of notes with blue severity.
        /// </summary>
        [MessagePack.Key(2)]
        public int SeverityBlueCount { get; init; }

        /// <summary>
        /// Total number of notes.
        /// </summary>
        [MessagePack.Key(3)]
        public int TotalCount { get; init; }

        #endregion
    }
}
