using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Order line creation model.
    /// </summary>
    [MessagePack.Union((int)OrderLineCreateType.Product,typeof(OrderLineCreateProductModel))]
    [MessagePack.Union((int)OrderLineCreateType.FixedTime, typeof(OrderLineCreateFixedTime))]
    [MessagePack.Union((int)OrderLineCreateType.Deposit, typeof(OrderLineCreateDepositModel))]
    public interface IOrderLineCreateModel
    {
        /// <summary>
        /// Gets line guid.
        /// </summary>
        /// <remarks>
        /// This uniquely identifies the line within the order.
        /// </remarks>
        public Guid? Guid { get; }

        /// <summary>
        /// Gets order line type.
        /// </summary>
        public OrderLineCreateType Type { get; }
    }
}
