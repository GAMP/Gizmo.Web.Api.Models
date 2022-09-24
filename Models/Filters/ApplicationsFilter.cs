using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for applications.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return applications with titles that contain the specified string.
        /// </summary>
        [Key(200)]
        public string ApplicationTitle { get; set; }

        /// <summary>
        /// Return applications that belongs to the specified category.
        /// </summary>
        [Key(201)]
        public int? CategoryId { get; set; } 

        #endregion
    }
}
