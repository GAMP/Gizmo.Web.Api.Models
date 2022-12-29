using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Note
{
    /// <summary>
    /// User note.
    /// </summary>
    [MessagePackObject]
    public sealed class UserNote : IUserNoteApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The text of the note.
        /// </summary>
        [Required]
        [StringLength(65535)]
        [MessagePack.Key(1)]
        public string Text { get; set; }

        /// <summary>
        /// The severity of the note.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public NoteSeverity Severity { get; set; }

        #endregion
    }
}
