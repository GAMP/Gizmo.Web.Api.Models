using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for billing profiles.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BillingProfilesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return billing profiles with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string BillingProfileName { get; set; } 

        #endregion
    }
}
