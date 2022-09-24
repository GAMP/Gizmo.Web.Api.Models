using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application licenses.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationLicensesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return licenses with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string LicenseName { get; set; } 

        #endregion
    }
}
