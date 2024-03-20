using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product price request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductPriceRequestModel : IWebApiModel
    {
        /// <summary>
        /// Product id.
        /// </summary>
        [MessagePack.Key(0)]
        [Required()]
        public int ProductId { get; init; }

        /// <summary>
        /// Optional user group.
        /// </summary>
        [MessagePack.Key(1)]
        public int? UserGroupId
        {
            get; init;
        }

        /// <summary>
        /// Product quantity. 1 By default.
        /// </summary>
        /// <remarks>
        /// Default value 1.
        /// </remarks>
        [MessagePack.Key(2)]
        public decimal Quantity
        {
            get; init;
        } = 1;
    }
}
