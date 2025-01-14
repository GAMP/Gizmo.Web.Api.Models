using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task notification model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskNotificationModel : TaskModel , IModelIntIdentifier , ITaskModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public Guid Guid { get; init; }

        /// <summary>
        /// Notification title.
        /// </summary>
        [MessagePack.Key(3)]
        public string Title { get; init; } = null!;

        /// <summary>
        /// Notification message.
        /// </summary>
        [MessagePack.Key(4)]
        public string Message { get; init; } = null!;

        /// <summary>
        /// Wait.
        /// </summary>
        [MessagePack.Key(5)]
        public bool Wait {  get; init; }
    }
}
