namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Product stock level change event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Change", "PRODUCT_STOCK_CHANGE_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates product stock level change", "PRODUCT_STOCK_CHANGE_EVENT_GROUP_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ProductStockChangeEventMessage : ProductStockChangeEventMessageBase
    {
        /// <summary>
        /// Gets on hand amount.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal OnHand
        {
            get;init;
        }

        /// <summary>
        /// Gets if alert level currently reached.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AlertLevelReached
        {
            get;init;
        }
    }
}
