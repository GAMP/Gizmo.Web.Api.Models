using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model.
    /// </summary>
    [MessagePack.Union((int)DiscountType.DiscountBasic, typeof(DiscountBasicModel))]
    [MessagePack.Union((int)DiscountType.DiscountBonusFlat, typeof(DiscountBonusFlatModel))]
    [MessagePack.Union((int)DiscountType.DiscountBonus, typeof(DiscountBonusModel))]
    [MessagePack.MessagePackObject()]
    public abstract class DiscountModel : IWebApiModel, IDiscountModel
    {
        /// <inheritdoc/>
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string? Description { get; init; }
    }
}
