using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserNoteModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The text of the note.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65535)]
        [MessagePack.Key(0)]
        public string Text { get; set; }

        /// <summary>
        /// The severity of the note.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public NoteSeverity Severity { get; set; }

        #endregion
    }
}