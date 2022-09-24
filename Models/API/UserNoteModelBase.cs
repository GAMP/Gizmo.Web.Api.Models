using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserNoteModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The text of the note.
        /// </summary>
        [Required]
        [StringLength(65535)]
        [MessagePack.Key(0)]
        public string Text { get; set; }

        /// <summary>
        /// The severity of the note.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public NoteSeverity Severity { get; set; }

        #endregion
    }
}