using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for associated hosts or devices.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DeviceHostFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Specifies explicit object id.
        /// </summary>
        [Key(200)]
        public int? Id
        {
            get; set;
        }

        /// <summary>
        /// Specifies host id.
        /// </summary>
        [Key(201)]
        public int? HostId
        {
            get; set;
        }

        /// <summary>
        /// Specifies device id.
        /// </summary>
        [Key(202)]
        public int? DeviceId
        {
            get; set;
        } 

        #endregion
    }
}
