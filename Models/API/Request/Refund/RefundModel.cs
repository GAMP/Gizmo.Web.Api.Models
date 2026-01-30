namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refund model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class RefundModel : IWebApiModel
    {
        /// <summary>
        /// Refund payment method method.
        /// </summary>
        /// <remarks>Set to <see langword="null"/> to indicate original tender refund.</remarks>
        [MessagePack.Key(0)]
        public int? RefundMethodId { get; init; }

        /// <summary>
        /// Refund amount.
        /// </summary>
        /// <remarks>
        /// This value is only used if <see cref="RefundMethodId"/> is specified.
        /// </remarks>
        [MessagePack.Key(1)]
        public decimal RefundAmount { get; init; }

        /// <summary>
        /// Disable receipt printing.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DisableReceiptPrinting { get; init; }
    }
}
