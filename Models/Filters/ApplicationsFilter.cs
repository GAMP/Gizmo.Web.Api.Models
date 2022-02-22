using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for applications.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return applications with titles that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public string ApplicationTitle { get; set; }

        /// <summary>
        /// Return applications that belongs to the specified category.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public int? CategoryId { get; set; }
    }
}
