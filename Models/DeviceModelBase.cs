using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device model base.
    /// </summary>
    public class DeviceModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        [StringLength(45)]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets if device is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets unique device ide.
        /// </summary>
        [StringLength(255)]
        [DataMember()]
        public string UniqueId { get; set; }

        #endregion
    }
}
