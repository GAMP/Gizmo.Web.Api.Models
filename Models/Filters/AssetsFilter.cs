using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for assets.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class AssetsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return assets with tags that contain the specified string.
        /// </summary>
        [MessagePack.Key(200)]
        public string Tag { get; set; }
    }
}
