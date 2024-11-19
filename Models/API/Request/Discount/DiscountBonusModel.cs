namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount bonus model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountBonusModel : DiscountModel
    {
        /// <summary>
        /// The value of the bonus.
        /// </summary>
        public int Value { get; set; }
    }
}
