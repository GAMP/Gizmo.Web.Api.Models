using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Hdmi Device model.
    /// </summary>
    [MessagePackObject()]
    public sealed class HdmiDevice
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets unique device ide.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        public string UniqueId { get; set; }

        #endregion
    }
}
