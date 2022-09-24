using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for hosts.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return hosts with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string HostName { get; set; }

        /// <summary>
        /// Return deleted hosts.
        /// </summary>
        [Key(201)]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
