using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Order line creation model.
    /// </summary>
    [MessagePack.Union((int)LineType.Product,typeof(OrderLineCreateProductModel))]
    [MessagePack.Union((int)LineType.TimeProduct, typeof(OrderLineCreateTimeProductModel))]
    [MessagePack.Union((int)LineType.FixedTime, typeof(OrderLineCreateFixedTime))]
    [MessagePack.Union((int)LineType.Deposit, typeof(OrderLineCreateDepositModel))]
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
        public LineType Type { get; }
    }
}
