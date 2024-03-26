namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order invoice model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoiceModel : IWebApiModel
    {
        /// <summary>
        /// Gets order.
        /// </summary>
        [MessagePack.Key(0)]
        public OrderCreateModel Order { get; init; } = new OrderCreateModel();

        /// <summary>
        /// Gets order invoice parameters.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderInvoiceParametersModel Parameters
        {
            get; init;
        } = new OrderInvoiceParametersModel();
    }
}
