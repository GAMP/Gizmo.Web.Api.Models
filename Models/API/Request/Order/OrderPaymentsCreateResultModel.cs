namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order payments create result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderPaymentsCreateResult : IWebApiModel
    {
        /// <summary>
        /// Gets invoice id.
        /// </summary>
        /// <remarks>
        /// This will only have value if the payment function succeeded.<br></br>
        /// This will have value of existing or newly created invoice.
        /// </remarks>
        [MessagePack.Key(0)]
        public int InvoiceId { get; init; }

        /// <summary>
        /// Indicates that new invoice was created.
        /// </summary>
        /// <remarks>
        /// If this value is false then existing invoice where used to execute payments.
        /// </remarks>
        [MessagePack.Key(1)]
        public bool InvoiceCreated { get; init; }
    }
}
