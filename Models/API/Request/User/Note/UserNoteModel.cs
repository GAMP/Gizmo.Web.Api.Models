using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserNoteModel : IUserNoteModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The text of the note.
        /// </summary>
        [StringLength(65535)]
        [MessagePack.Key(1)]
        public string Text { get; set; } = null!;

        /// <summary>
        /// The severity of the note.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public NoteSeverity Severity { get; set; }

        /// <summary>
        /// The Id of the operator who created the note.
        /// </summary>
        [MessagePack.Key(3)]
        public int? CreatedById { get; set; }

        /// <summary>
        /// The date that the note was created.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime CreatedTime { get; set; }

        #endregion
    }
}
