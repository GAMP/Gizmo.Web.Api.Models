using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for hosts.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return hosts with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string HostName { get; set; }

        /// <summary>
        /// Return deleted hosts.
        /// </summary>
        [DataMember]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
