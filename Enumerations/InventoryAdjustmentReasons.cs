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
        [Name("Expired")]
        Expired = -1,
        /// <summary>
        /// Product packaging is damaged.
        /// </summary>
        [Name("Damaged packaging")]
        Damaged = -2,
        /// <summary>
        /// Product is damaged.
        /// </summary>
        [Name("Damaged item")]
        DamagedItem = -3,
        /// <summary>
        /// Product is lost.
        /// </summary>
        [Name("Lost")]
        Lost = -4,
        /// <summary>
        /// Product is not in demand.
        /// </summary>
        [Name("Not in demand")]
        NotInDemand = -5,
        /// <summary>
        /// Force major circumstances.
        /// </summary>
        [Name("Force major")]
        ForceMajor = -6,
    }
}
