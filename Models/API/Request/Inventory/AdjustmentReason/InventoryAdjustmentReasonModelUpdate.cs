using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment reason update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryAdjustmentReasonModelUpdate : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Name.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Description.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? Description { get; init; } = null!;
    }
}
