using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.DisallowedUserGroup
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductDisallowedUserGroupModelUpdate : IProductDisallowedUserGroupApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}