using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Icon
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostIconModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}
