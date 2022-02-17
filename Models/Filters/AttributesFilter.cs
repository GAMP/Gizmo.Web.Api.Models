using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for attributes.
    /// </summary>
    [Serializable]
    [DataContract]
    public class AttributesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return attributes with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string AttributeName { get; set; }
    }
}
