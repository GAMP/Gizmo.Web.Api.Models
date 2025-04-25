using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment reason create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryAdjustmentReasonModelCreate : IWebApiModel
    {
        /// <summary>
        /// Name.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Description.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string? Description { get; init; } = null!;
    }
}
