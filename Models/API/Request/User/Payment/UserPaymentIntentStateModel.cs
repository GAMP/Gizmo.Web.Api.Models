using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// State of a payment of the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPaymentIntentStateModel : IWebApiModel
    {
        /// <summary>
        /// Payment intent id.
        /// </summary>
        [Key(0)]
        public Guid Intent { get; init; }

        /// <summary>
        /// Payment intent state.
        /// </summary>
        [Key(1)]
        public PaymentIntentState State { get; init; }
    }
}
