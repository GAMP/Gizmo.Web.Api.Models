using MessagePack;
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
    [MessagePackObject]
    public class ApplicationTaskModelBase
    {
        /// <summary>
        /// The name of the task.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The junction object attached to this task if the task is a junction task, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public ApplicationTaskJunction TaskJunction { get; set; }

        /// <summary>
        /// The notification object attached to this task if the task is a notification task, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public ApplicationTaskNotification TaskNotification { get; set; }

        /// <summary>
        /// The process object attached to this task if the task is a process task, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public ApplicationTaskProcess TaskProcess { get; set; }

        /// <summary>
        /// The script object attached to this task if the task is a script task, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public ApplicationTaskScript TaskScript { get; set; }
    }
}