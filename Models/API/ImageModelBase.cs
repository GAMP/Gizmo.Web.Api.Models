using MessagePack;
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
    [MessagePackObject]
    public class ImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}