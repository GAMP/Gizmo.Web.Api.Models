using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.HiddenHostGroup
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductHiddenHostGroupModelCreate : IProductHiddenHostGroupApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this product is hidden in this host group.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsHidden { get; set; }

        #endregion
    }
}
