using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationTaskModelBase
    {
        /// <summary>
        /// The name of the task.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        public ApplicationTaskJunction TaskJunction { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        public ApplicationTaskNotification TaskNotification { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        public ApplicationTaskProcess TaskProcess { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        public ApplicationTaskScript TaskScript { get; set; }
    }
}