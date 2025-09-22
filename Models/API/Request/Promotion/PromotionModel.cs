namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion model.
    /// </summary>
    [MessagePack.Union((int)PromotionTypes.Discount, typeof(PromotionDiscountModel))]
    [MessagePack.Union((int)PromotionTypes.DiscountGroup, typeof(PromotionDiscountGroupModel))]
    public abstract class PromotionModel : IWebApiModel
    {
    }
}
