using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductUserPriceModelUpdate : ProductUserPriceModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(200)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this user price is associated with.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(201)]
        public int ProductId { get; set; }

        #endregion
    }
}