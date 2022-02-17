using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application enterprises.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationEnterprisesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
