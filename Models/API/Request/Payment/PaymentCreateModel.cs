namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentCreateModel : IWebApiModel
    {
        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentMethodId
        {
            get;init;
        }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount
        {
            get;init;
        }

        /// <summary>
        /// Optional payment received amount.
        /// </summary>
        /// <remarks>
        /// The value will be equal to <see cref="Amount"/> if not set.
        /// </remarks>
        [MessagePack.Key(2)]
        public decimal? ReceivedAmount
        {
            get; init;
        }
    }
}
