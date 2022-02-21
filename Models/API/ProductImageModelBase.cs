using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}