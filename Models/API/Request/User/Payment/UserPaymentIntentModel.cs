using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Started online payment.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPaymentIntentModel : IWebApiModel
    {
        /// <summary>
        /// Payment intent id.
        /// </summary>
        [Key(0)]
        public Guid Intent { get; init; }

        /// <summary>
        /// Url of the payment page of the provider.
        /// </summary>
        [Key(1)]
        public string PaymentUrl { get; init; } = string.Empty;

        /// <summary>
        /// Amount to pay.
        /// </summary>
        [Key(2)]
        public decimal Amount { get; init; }
    }
}
