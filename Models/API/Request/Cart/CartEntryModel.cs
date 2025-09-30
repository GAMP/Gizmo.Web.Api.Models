using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart entry model.
    /// </summary>
    [MessagePack.Union((int)CartEntryType.Product, typeof(CartEntryProductModel))]
    [MessagePack.Union((int)CartEntryType.Deposit, typeof(CartEntryDepositModel))]
    [MessagePack.MessagePackObject()]
    public abstract class CartEntryModel : IWebApiModel
    {
        // totals can be computed client side, no need to use them in payload
    }

    /// <summary>
    /// Cart entry product model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartEntryProductModel : CartEntryModel
    {
        /// <summary>
        /// Entry id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// Product id.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; init; }

        /// <summary>
        /// Unit price.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal UnitPrice { get; init; }

        /// <summary>
        /// Unit points price.
        /// </summary>
        [MessagePack.Key(3)]
        public int UnitPointsPrice { get; init; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; init; }

        /// <summary>
        /// Total points.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal PointsTotal { get; init; }

        /// <summary>
        /// Subtotal.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal SubTotal { get; init; }

        /// <summary>
        /// Tax total.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal TaxTotal { get; init; }

        /// <summary>
        /// Discount total.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Discount { get; init; }

        /// <summary>
        /// Total.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Total { get; init; }

        /// <summary>
        /// Points award.
        /// </summary>
        [MessagePack.Key(10)]
        public int PointsAward { get; init; }

        /// <summary>
        /// Indicates marked entry.
        /// </summary>
        [MessagePack.Key(11)]
        public bool IsMarked {  get; init; }

        /// <summary>
        /// Unit list price.
        /// </summary>
        [MessagePack.Key(12)]
        public decimal UnitListPrice { get; init; }
    }

    /// <summary>
    /// Cart entry deposit model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartEntryDepositModel : CartEntryModel
    {
        /// <summary>
        /// Entry id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// Deposit amount.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal UnitPrice { get; init; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Quantity { get; init; }

        /// <summary>
        /// Subtotal.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal SubTotal { get; init; }

        /// <summary>
        /// Tax total.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal TaxTotal { get; init; }

        /// <summary>
        /// Total.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Total { get; init; }
    }
}
