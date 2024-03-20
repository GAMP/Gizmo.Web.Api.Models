using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product price request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductUserPriceRequestModel : IWebApiModel
    {
        /// <summary>
        /// Product id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(1)]
        [Required()]
        public int UserId
        {
            get; init;
        }

        /// <summary>
        /// Product quantity.
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
