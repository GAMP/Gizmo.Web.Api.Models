namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount basic model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountBasicModel : DiscountModel
    {
        /// <summary>
        /// Value.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal? Value { get; init; }
    }
}
