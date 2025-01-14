using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task junction model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskJunctionModel : TaskModel , IModelIntIdentifier , ITaskModel
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
        /// Source directory.
        /// </summary>
        [MessagePack.Key(3)]
        public string SourceDirectory { get;init; } = null!;

        /// <summary>
        /// Destination directory.
        /// </summary>
        [MessagePack.Key(4)]
        public string DestinationDirectory { get;init; } = null!;

        /// <summary>
        /// Delete destination.
        /// </summary>
        [MessagePack.Key(5)]
        public bool DeleteDestination { get; init; } = false!;
    }
}
