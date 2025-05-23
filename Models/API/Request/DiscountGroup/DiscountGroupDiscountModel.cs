namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount group discount model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountGroupDiscountModel : IWebApiModel
    {
        /// <summary>
        /// Discount id.
        /// </summary>
        [MessagePack.Key(0)]
        public int DiscountId { get; init; }
    }
}
