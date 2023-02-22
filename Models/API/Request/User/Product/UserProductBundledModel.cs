using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product bundled model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductBundledModel
    {
        /// <summary>
        /// The Id of the bundled product.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the bundled product.
        /// </summary>
        public int Quantity { get; set; }
    }
}
