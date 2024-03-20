using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product order line.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class OrderLineProductModel : IUriParametersQuery
    {
        /// <summary>
        /// The Id of the product.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductId { get; set; }
    }
}
