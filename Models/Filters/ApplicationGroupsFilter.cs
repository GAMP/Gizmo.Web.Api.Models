using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application groups.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return groups with names that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public string GroupName { get; set; }
    }
}