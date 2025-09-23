using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion limit model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PromotionLimitModel : IWebApiModel
    {
        /// <summary>
        /// Promotion limit type.
        /// </summary>
        [MessagePack.Key(0)]
        public PromotionLimitType LimitType { get; set; }

        /// <summary>
        /// Promotion limit.
        /// </summary>
        [MessagePack.Key(1)]
        [Range(1,int.MaxValue)]
        public int Limit { get; set; }
    }
}
