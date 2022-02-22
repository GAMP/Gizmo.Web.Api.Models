using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for billing profiles.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class BillingProfilesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return billing profiles with names that contain the specified string.
        /// </summary>
        [MessagePack.Key(200)]
        public string BillingProfileName { get; set; }
    }
}
