namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart promotion add model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartPromotionCodeAddModel : IWebApiModel
    {
        [MessagePack.Key(0)]
        public string Code { get; init; }
    }
}
