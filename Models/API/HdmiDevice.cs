using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Hdmi Device model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class HdmiDevice
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets unique device ide.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string UniqueId { get; set; }

        #endregion
    }
}
