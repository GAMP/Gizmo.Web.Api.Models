namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent cancel result model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class PaymentIntentCancelResultModel : IWebApiModel
    {
        /// <summary>
        /// Result code.
        /// </summary>
        [MessagePack.Key(0)]
        public PaymentIntentCancelResult Result { get; init; }

        /// <summary>
        /// Provider result.
        /// </summary>
        [MessagePack.Key(1)]
        public PaymentIntentCancelProviderResult ProviderResult { get; init; }
    }
}
