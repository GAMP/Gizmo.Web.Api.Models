using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task notification.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class ApplicationTaskNotification
    {
        #region PROPERTIES

        /// <summary>
        /// The title of the notification.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Title { get; set; }

        /// <summary>
        /// The message of the notification.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65536)]
        [MessagePack.Key(1)]
        public string Message { get; set; }

        /// <summary>
        /// Whether to wait until the user responds to the notification.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool Wait { get; set; }

        #endregion
    }
}