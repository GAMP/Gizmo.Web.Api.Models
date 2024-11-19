namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount bonus flat model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountBonusFlatModel : DiscountModel
    {
        /// <summary>
        /// The value of the bonus.
        /// </summary>
        public int Value { get; set; }
    }
}
