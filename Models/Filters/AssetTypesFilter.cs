using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for asset types.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetTypesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return asset types with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string AssetTypeName { get; set; } 

        #endregion
    }
}