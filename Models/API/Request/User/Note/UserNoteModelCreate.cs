#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [MessagePackObject]
    public sealed class UserNoteModelCreate : IUserNoteApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The text of the note.
        /// </summary>
        [Required]
        [StringLength(65535)]
        [MessagePack.Key(0)]
        public string Text { get; set; } = null!;

        /// <summary>
        /// The severity of the note.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public NoteSeverity Severity { get; set; }

        #endregion
    }
}
