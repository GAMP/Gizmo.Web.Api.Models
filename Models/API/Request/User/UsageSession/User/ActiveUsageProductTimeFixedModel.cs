namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage product time fixed model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActiveUsageProductTimeFixedModel : ActiveUsageModel
    {
        /// <summary>
        /// Gets purchase invoice line id.
        /// </summary>
        [MessagePack.Key(3)]
        public int InvoiceLineId { get; init; }
    }
}
