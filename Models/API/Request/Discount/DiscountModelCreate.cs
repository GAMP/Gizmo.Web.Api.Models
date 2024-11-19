namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model create.
    /// </summary>
    [MessagePack.Union((int)DiscountType.DiscountBonusFlat, typeof(DiscountBonusFlatModelCreate))]
    [MessagePack.Union((int)DiscountType.DiscountBonus, typeof(DiscountBonusModelCreate))]
    [MessagePack.Union((int)DiscountType.DiscountBasic, typeof(DiscountBasicModelCreate))]
    [MessagePack.MessagePackObject]
    public abstract class DiscountModelCreate : IDiscountModel
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public string? Description { get; init; } = null!;
    }
}
