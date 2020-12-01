using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [DataMember]
        public byte[] Image { get; set; }

        #endregion
    }
}