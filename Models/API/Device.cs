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
    public class Device: DeviceModelBase, IEntityBase
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
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// Gets device type.
        /// </summary>
        [DataMember]
        [Key(101)]
        public DeviceType DeviceType { get; set; }

        #endregion
    }
}
