#nullable enable

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line product.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductLineModel : IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Key(0)]
        public int ProductId { get; set; }

        #endregion
    }
}
