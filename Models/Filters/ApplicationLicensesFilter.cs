using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application licenses.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationLicensesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return licenses with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string LicenseName { get; set; }
    }
}
