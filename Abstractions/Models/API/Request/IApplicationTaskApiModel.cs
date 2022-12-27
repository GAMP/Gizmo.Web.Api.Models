using Gizmo.Web.Api.Models.Models.API.Request.Application.Task;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Application task.
    /// </summary>
    public interface IApplicationTaskApiModel
    {
        /// <summary>
        /// The name of the task.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The junction object attached to this task if the task is a junction task, otherwise it will be null.
        /// </summary>
        ApplicationTaskJunction TaskJunction { get; set; }

        /// <summary>
        /// The notification object attached to this task if the task is a notification task, otherwise it will be null.
        /// </summary>
        ApplicationTaskNotification TaskNotification { get; set; }

        /// <summary>
        /// The process object attached to this task if the task is a process task, otherwise it will be null.
        /// </summary>
        ApplicationTaskProcess TaskProcess { get; set; }

        /// <summary>
        /// The script object attached to this task if the task is a script task, otherwise it will be null.
        /// </summary>
        ApplicationTaskScript TaskScript { get; set; }
    }
}