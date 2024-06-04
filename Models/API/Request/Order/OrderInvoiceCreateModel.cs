namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order invoice model.
    /// </summary>
    /// <remarks>
    /// Order creation parameters with additional invoicing.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoiceCreateModel : IWebApiModel
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
        public OrderInvoicingParametersModel Parameters
        {
            get; init;
        } = new OrderInvoicingParametersModel();
    }
}
