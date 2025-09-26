namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion branch model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PromotionBranchModel : IWebApiModel
    {
        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(0)]
        public int BranchId { get; init; }

        /// <summary>
        /// Branch is enabled.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsEnabled { get; init; }
    }
}
