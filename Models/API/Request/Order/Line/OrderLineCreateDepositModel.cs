using System;
using Gizmo.Web.Api.Models.Abstractions;

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
        public LineType Type => LineType.Deposit;

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
