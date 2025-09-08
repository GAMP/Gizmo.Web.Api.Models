namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// General order totals contract.
    /// </summary>
    public interface IOrderTotals
    {
        /// <summary>
        /// Sub total.
        /// </summary>
        /// <remarks>
        /// Sub total before tax and discounts.<br></br>
        /// </remarks>
        public decimal SubTotal { get; }

        /// <summary>
        /// Total tax amount.
        /// </summary>
        /// <remarks>The total amount representing tax.</remarks>
        public decimal TaxTotal { get; }

        /// <summary>
        /// Total points amount.
        /// </summary>
        /// <remarks>The total amount of points this order costs (requires).</remarks>
        public int PointsTotal { get; }

        /// <summary>
        /// Total discount amount.
        /// </summary>
        public decimal Discount { get; }

        /// <summary>
        /// Total amount.
        /// </summary>
        public decimal Total { get; }    

        /// <summary>
        /// Total points award amount.
        /// </summary>
        public int PointsAward { get; }
    }
}
