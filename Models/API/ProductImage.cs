using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductImage : ProductImageModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this image belongs to.
        /// </summary>
        [DataMember]
        public int ProductId { get; set; }

        #endregion
    }
}