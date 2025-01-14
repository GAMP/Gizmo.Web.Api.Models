using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task process model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskProcessModel : TaskModel, IModelIntIdentifier , ITaskModel
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
        /// File name.
        /// </summary>
        [MessagePack.Key(3)]
        public string FileName { get; init; } = null!;

        /// <summary>
        /// Arguments.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Arguments { get; init; }

        /// <summary>
        /// Working directory.
        /// </summary>
        [MessagePack.Key(5)]
        public string? WorkingDirectory { get; init; }

        /// <summary>
        /// Wait.
        /// </summary>
        [MessagePack.Key(6)]
        public bool Wait { get; init; }

        /// <summary>
        /// Hide main window.
        /// </summary>
        [MessagePack.Key(7)]
        public bool Hide {  get; init; }
    }
}
