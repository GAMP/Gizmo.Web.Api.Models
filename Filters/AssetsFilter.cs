using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for assets.
    /// </summary>
    [Serializable]
    [DataContract]
    public class AssetsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return assets with tags that contain the specified string.
        /// </summary>
        public string Tag { get; set; }
    }
}
