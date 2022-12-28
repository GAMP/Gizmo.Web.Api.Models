using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.DisallowedUserGroup
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductDisallowedUserGroupModelCreate : IProductDisallowedUserGroupApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether this user group is disallowed for this product.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}