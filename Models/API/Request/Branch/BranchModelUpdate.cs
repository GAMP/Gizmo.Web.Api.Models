using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchModelUpdate : IModelIntIdentifier, IBranchModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? TimeZone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public bool IsDefault { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public bool IsEnabled { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public bool IsDeleted { get; init; }
    }
}
