using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device model base.
    /// </summary>
    [Serializable()]
    [DataContract]
    [MessagePackObject()]
    [Union(0, typeof(DeviceModelCreate))]
    [Union(1, typeof(DeviceModelUpdate))]
    public class DeviceModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        [StringLength(45)]
        [DataMember]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if device is enabled.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets if device is deleted.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets unique device ide.
        /// </summary>
        [StringLength(255)]
        [DataMember()]
        [MessagePack.Key(3)]
        public string UniqueId { get; set; }

        #endregion
    }
}
