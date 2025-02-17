namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Usage session invoice result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageSessionActiveInvoiceResultModel : IWebApiModel
    {
        /// <summary>
        /// Optional invoice id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? InvoiceId { get; init; }
    }
}
