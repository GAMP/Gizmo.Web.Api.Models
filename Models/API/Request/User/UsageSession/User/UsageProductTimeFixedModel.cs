namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage product time fixed model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageProductTimeFixedModel : UsageModel
    {
        /// <summary>
        /// Gets purchase invoice line id.
        /// </summary>
        [MessagePack.Key(2)]
        public int InvoiceLineId { get; init; }
    }
}
