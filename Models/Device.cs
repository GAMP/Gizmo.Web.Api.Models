using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class Device
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Device()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [DataMember]
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets device name.
        /// </summary>
        [DataMember]
        [Key(1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets if device is deleted.
        /// </summary>
        [DataMember]
        [Key(2)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets if device is enabled.
        /// </summary>
        [DataMember]
        [Key(3)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets device type.
        /// </summary>
        [DataMember]
        [Key(4)]
        public DeviceType Type { get; set; }

        #endregion
    }
}
