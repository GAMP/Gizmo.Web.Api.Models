using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User picture.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserPicture
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public byte[] Picture { get; set; }

        #endregion
    }
}