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
    public class ApplicationTaskNotification
    {
        #region PROPERTIES

        /// <summary>
        /// The title of the notification.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// The message of the notification.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65536)]
        public string Message { get; set; }

        /// <summary>
        /// Whether to wait until the user responds to the notification.
        /// </summary>
        [DataMember]
        public bool Wait { get; set; }

        #endregion
    }
}