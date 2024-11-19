using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount bonus model create.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DiscountBonusModelCreate : DiscountModelCreate
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [Range(1, int.MaxValue)]
        [MessagePack.Key(2)]
        public int Value { get; init; }
    }
}
