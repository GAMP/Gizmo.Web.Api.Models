using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment reason model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryAdjustmentReasonModel : IWebApiModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Description.
        /// </summary>
        [MessagePack.Key(2)]
        public string Description { get; init; } = null!;

        /// <summary>
        /// Is deleted.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsDeleted { get; init; }
    }
}
