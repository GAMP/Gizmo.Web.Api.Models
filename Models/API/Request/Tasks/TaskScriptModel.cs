using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task script model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskScriptModel : TaskModel, IModelIntIdentifier, ITaskModel
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
        /// Script type.
        /// </summary>
        [MessagePack.Key(3)]
        public ScriptTypes Type { get; init; }

        /// <summary>
        /// Script type.
        /// </summary>
        [MessagePack.Key(4)]
        public string Script { get; init; } = null!;

        /// <summary>
        /// Wait for exit.
        /// </summary>
        [MessagePack.Key(5)]
        public bool Wait { get; init; }

        /// <summary>
        /// Hide main window.
        /// </summary>
        [MessagePack.Key(6)]
        public bool Hide { get; init; }
    }
}
