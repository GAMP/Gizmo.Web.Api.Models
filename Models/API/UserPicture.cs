using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User picture.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserPicture
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public byte[] Picture { get; set; }

        #endregion
    }
}