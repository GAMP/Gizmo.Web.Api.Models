using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}