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
        /// Return deleted hosts.
        /// </summary>
        [DataMember]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
