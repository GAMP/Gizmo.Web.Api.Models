namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product price request response model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductPriceRequestResponseModel : IWebApiModel
    {
        /// <summary>
        /// Unit price.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal UnitPrice { get; init; }

        /// <summary>
        /// Total product price.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal TotalPrice { get; init; }

        /// <summary>
        /// Unit points price.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UnitPointsPrice { get; init; }

        /// <summary>
        /// Total points price.
        /// </summary>
        [MessagePack.Key(3)]
        public int? TotalPointsPrice { get; init; }

        /// <summary>
        /// Purchase options.
        /// </summary>
        [MessagePack.Key(4)]
        public Gizmo.PurchaseOptionType PurchaseOptions
        {
            get; init;
        }
    }
}
