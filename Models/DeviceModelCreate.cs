using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device creation model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class DeviceModelCreate : DeviceModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets device type.
        /// </summary>
        [DataMember]
        [Key(4)]
        public DeviceType Type { get; set; } 

        #endregion
    }
}
