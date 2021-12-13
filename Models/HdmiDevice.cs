using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Hdmi Device model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class HdmiDevice
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets unique device ide.
        /// </summary>
        [StringLength(255)]
        [DataMember()]
        [MessagePack.Key(0)]
        public string UniqueId { get; set; }

        #endregion
    }
}
