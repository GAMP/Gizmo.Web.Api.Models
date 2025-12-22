namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment reversal model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class PaymentReversalModel : IWebApiModel
    {
        /// <summary>
        /// Indicates an void.
        /// </summary>
        /// <remarks>
        /// Setting this to true indicates that the payment recipients will be voided.
        /// </remarks>
        [MessagePack.Key(0)]
        public bool Void { get; init; }
    }
}
