using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartCreateModel : IWebApiModel
    {
        /// <summary>
        /// Cart expiration time in minutes.
        /// </summary>
        /// <remarks>
        /// This value will override the default expiration time.<br></br>
        /// </remarks>
        [MessagePack.Key(0)]
        [DefaultValue(null)]
        [Range(1, int.MaxValue)]
        public int? ExpireAfter { get; init; }

        /// <summary>
        /// Disable discounts.
        /// </summary>
        [MessagePack.Key(1)]
        [DefaultValue(false)]
        public bool DisableDiscounts { get; init; }
    }
}
