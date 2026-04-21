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

        /// <summary>
        /// Discount is disabled.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Discount is deleted.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsDeleted { get; init; }
    }
}
