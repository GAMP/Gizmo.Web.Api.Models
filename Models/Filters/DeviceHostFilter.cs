using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for associated hosts or devices.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class DeviceHostFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Specifies explicit object id.
        /// </summary>
        [DataMember()]
        [MessagePack.Key(200)]
        public int? Id
        {
            get; set;
        }

        /// <summary>
        /// Specifies host id.
        /// </summary>
        [DataMember()]
        [MessagePack.Key(201)]
        public int? HostId
        {
            get; set;
        }

        /// <summary>
        /// Specifies device id.
        /// </summary>
        [DataMember()]
        [MessagePack.Key(202)]
        public int? DeviceId
        {
            get; set;
        } 

        #endregion
    }
}
