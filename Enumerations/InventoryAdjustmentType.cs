namespace Gizmo.Web.Api
{
    /// <summary>
    /// Inventory adjustment type.
    /// </summary>
    public enum InventoryAdjustmentType
    {
        /// <summary>
        /// Write off.
        /// </summary>
        WriteOff = 0,

        /// <summary>
        /// Sale by purchase.
        /// </summary>
        SaleByPurchase = 1,

        /// <summary>
        /// Sale by price.
        /// </summary>
        SaleByPrice = 2,
    }
}
