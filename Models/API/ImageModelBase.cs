using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Image.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data.
        /// </summary>
        [DataMember]
        [Required]
        public byte[] Image { get; set; }

        #endregion
    }
}