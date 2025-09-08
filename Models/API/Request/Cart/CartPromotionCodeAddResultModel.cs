using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion code add model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartPromotionCodeAddResultModel : IWebApiModel
    {
        /// <summary>
        /// Promotion code cart id.
        /// </summary>
        /// <remarks>
        /// Id that represents applied promotion code within the cart.<br></br>
        /// </remarks>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// Promotion id that was applied.
        /// </summary>
        [MessagePack.Key(1)]
        public int PromotionId { get; init; }
    }
}
