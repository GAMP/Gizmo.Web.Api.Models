using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchModelUpdate : IModelIntIdentifier, IBranchModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;
    }
}
