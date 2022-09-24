using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for devices.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DevicesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return devices of the specified device type.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(200)]
        public DeviceType? DeviceType { get; set; }

        #endregion
    }
}
