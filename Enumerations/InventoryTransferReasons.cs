using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory transfer reasons enumeration.
    /// </summary>
    public enum InventoryTransferReasons
    {
        /// <summary>
        /// Product is in demand.
        /// </summary>
        [Name("In demand", "INVENTORY_TRANSFER_REASONS_IN_DEMAND")]
        InDemand = -1,
        /// <summary>
        /// Product is not in demand.
        /// </summary>
        [Name("Not in demand", "INVENTORY_TRANSFER_REASONS_NOT_IN_DEMAND")]
        NotInDemand = -2,
        /// <summary>
        /// For adjustment purposes.
        /// </summary>
        /// <remarks>
        /// Used in cases where inventory is being transferred for adjustment, such as correcting stock levels or addressing discrepancies.
        /// </remarks>
        [Name("For adjustment", "INVENTORY_TRANSFER_REASONS_FOR_ADJUSTMENT")]
        ForAdjustment = -3,
    }
}
