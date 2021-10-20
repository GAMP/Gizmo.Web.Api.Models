using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device creation model.
    /// </summary>
    [Serializable]
    [DataContract]
    public class DeviceModelCreate : DeviceModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets device type.
        /// </summary>
        [DataMember]
        public DeviceType Type { get; set; } 

        #endregion
    }
}
