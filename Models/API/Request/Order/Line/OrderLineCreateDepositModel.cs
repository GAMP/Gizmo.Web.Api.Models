using System;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit order line.
    /// </summary>
    public sealed class OrderLineCreateDepositModel : IOrderLineCreateModel
    {
        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        public OrderLineCreateType Type =>  OrderLineCreateType.Deposit;

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// Gets deposit amount.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount { get; init; } = decimal.Zero;
    }
}
