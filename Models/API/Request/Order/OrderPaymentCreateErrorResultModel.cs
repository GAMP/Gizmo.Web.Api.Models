using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order payment processing creation result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderPaymentCreateErrorResultModel : IWebApiModel
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
        /// Result.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderPaymentCreateErrorResult Result { get; init; }
    }
}
