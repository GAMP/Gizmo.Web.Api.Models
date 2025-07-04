using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory type.
    /// </summary>
    public enum InventoryType
    {
        /// <summary>
        /// Inbound.
        /// </summary>
        [Name("Inbound", "INVENTORY_TYPE_INBOUND")]
        Inbound = 0,
        /// <summary>
        /// Transfer.
        /// </summary>
        [Name("Transfer", "INVENTORY_TYPE_TRANSFER")]
        Transfer = 1,
        /// <summary>
        /// Adjustment.
        /// </summary>
        [Name("Adjustment", "INVENTORY_TYPE_ADJUSTMENT")]
        Adjustment = 2
    }
}
