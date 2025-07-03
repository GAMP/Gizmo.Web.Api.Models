using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment reasons enumeration.
    /// </summary>
    public enum InventoryAdjustmentReasons
    {
        /// <summary>
        /// Product expired.
        /// </summary>
        [Name("Expired", "INVENTORY_ADJUSTMENT_REASONS_EXPIRED")]
        Expired = -1,
        /// <summary>
        /// Product packaging is damaged.
        /// </summary>
        [Name("Damaged packaging", "INVENTORY_ADJUSTMENT_REASONS_DAMAGED")]
        Damaged = -2,
        /// <summary>
        /// Product is damaged.
        /// </summary>
        [Name("Damaged item", "INVENTORY_ADJUSTMENT_REASONS_DAMAGED_ITEM")]
        DamagedItem = -3,
        /// <summary>
        /// Product is lost.
        /// </summary>
        [Name("Lost", "INVENTORY_ADJUSTMENT_REASONS_LOST")]
        Lost = -4,
        /// <summary>
        /// Product is not in demand.
        /// </summary>
        [Name("Not in demand", "INVENTORY_ADJUSTMENT_REASONS_NOT_IN_DEMAND")]
        NotInDemand = -5,
        /// <summary>
        /// Force major circumstances.
        /// </summary>
        [Name("Force major", "INVENTORY_ADJUSTMENT_REASONS_FORCE_MAJOR")]
        ForceMajor = -6,
    }
}
