namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage time model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActiveUsageProductTimeModel : ActiveUsageModel
    {
        /// <summary>
        /// Gets purchase invoice line id.
        /// </summary>
        [MessagePack.Key(3)]
        public int InvoiceLineId { get; init; }

        /// <summary>
        /// Gets product time id.
        /// </summary>
        [MessagePack.Key(4)]
        public int ProductTimeId { get; init; }
    }
}
