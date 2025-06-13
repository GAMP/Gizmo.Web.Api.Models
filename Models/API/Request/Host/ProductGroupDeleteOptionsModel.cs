using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroupDeleteOptionsModel : IUriParametersQuery
    {
        /// <summary>
        /// The id of the product group to move products before delete.
        /// </summary>
        [MessagePack.Key(0)]
        public int? MoveToProductGroupId { get; init; }
    }
}
