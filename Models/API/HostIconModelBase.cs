using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [DataContract]
    [Serializable]
    public class HostIconModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        [DataMember]
        [Required]
        public byte[] Image { get; set; }

        #endregion
    }
}
