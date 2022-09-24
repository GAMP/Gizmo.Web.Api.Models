using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for attributes.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AttributesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return attributes with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string AttributeName { get; set; } 

        #endregion
    }
}
