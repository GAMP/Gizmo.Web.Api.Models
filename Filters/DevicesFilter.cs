using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for devices.
    /// </summary>
    [Serializable]
    [DataContract]
    public class DevicesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return devices of the specified device type.
        /// </summary>
        [DataMember]
        [EnumValue]
        public DeviceType? DeviceType { get; set; }

        /// <summary>
        /// Return deleted devices.
        /// </summary>
        [DataMember]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
