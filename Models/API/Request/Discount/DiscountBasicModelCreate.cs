using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount basic model create.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DiscountBasicModelCreate : DiscountModelCreate
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [Range(1, int.MaxValue)]
        [MessagePack.Key(2)]
        public decimal? Value { get; init; }
    }
}
