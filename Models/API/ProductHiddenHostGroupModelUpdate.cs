using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductHiddenHostGroupModelUpdate : ProductHiddenHostGroupModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [DataMember]
        [Required]
        public int ProductId { get; set; }

        #endregion
    }
}
