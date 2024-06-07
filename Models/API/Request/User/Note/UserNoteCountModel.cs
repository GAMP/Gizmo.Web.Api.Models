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
        /// Number of notes with green severity.
        /// </summary>
        [MessagePack.Key(0)]
        public int SeverityGreenCount { get; init; }
        
        /// <summary>
        /// Number of notes with yellow severity.
        /// </summary>
        [MessagePack.Key(1)]
        public int SeverityYellowCount { get; init; }

        /// <summary>
        /// Number of notes with red severity.
        /// </summary>
        [MessagePack.Key(2)]
        public int SeverityRedCount { get; init; }

        /// <summary>
        /// Total number of notes.
        /// </summary>
        [MessagePack.Key(3)]
        public int TotalCount { get; init; }

        #endregion
    }
}
