using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.HiddenHostGroup
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductHiddenHostGroup : ProductHiddenHostGroupModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Key(101)]
        public int ProductId { get; set; }

        #endregion
    }
}
