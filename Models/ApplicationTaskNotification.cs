using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Gets
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApplicationTaskNotification
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets notification title.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets notification message.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(65536)]
        public string Message { get; set; }

        ///// <summary>
        ///// Gets or sets notification options.
        ///// </summary>
        //[DataMember]
        //TODO: A public TaskNotificationOptionType NotificationOptions { get; set; }

        #endregion
    }
}