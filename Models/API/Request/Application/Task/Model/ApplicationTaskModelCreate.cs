﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Task.Model
{
    /// <summary>
    /// Application task.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationTaskModelCreate : IApplicationTaskApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the application task.
        /// </summary>
        [MessagePack.Key(0)]
        [EnumValueValidation]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The junction object attached to this task if the task is a junction task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(2)]
        public ApplicationTaskJunction TaskJunction { get; set; }

        /// <summary>
        /// The notification object attached to this task if the task is a notification task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(3)]
        public ApplicationTaskNotification TaskNotification { get; set; }

        /// <summary>
        /// The process object attached to this task if the task is a process task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(4)]
        public ApplicationTaskProcess TaskProcess { get; set; }

        /// <summary>
        /// The script object attached to this task if the task is a script task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(5)]
        public ApplicationTaskScript TaskScript { get; set; }

        #endregion
    }
}
