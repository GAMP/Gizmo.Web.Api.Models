using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for assets.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return assets with tags that contain the specified string.
        /// </summary>
        [Key(200)]
        public string Tag { get; set; } 

        #endregion
    }
}
