namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Product stock event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Product stock", "PRODUCT_STOCK_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Product stock related events", "PRODUCT_STOCK_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(16)]
    public abstract class ProductStockChangeEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// Gets product id.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId
        {
            get; init;
        }
    }
}
