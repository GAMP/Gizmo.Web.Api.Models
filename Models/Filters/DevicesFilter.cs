using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for devices.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class DevicesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return devices of the specified device type.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(200)]
        public DeviceType? DeviceType { get; set; }

        #endregion
    }
}
