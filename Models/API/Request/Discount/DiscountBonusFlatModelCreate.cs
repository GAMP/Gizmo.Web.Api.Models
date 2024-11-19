namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount bonus flat model create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountBonusFlatModelCreate : DiscountModelCreate
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [MessagePack.Key(2)]
        public int Value { get; init; }
    }
}
