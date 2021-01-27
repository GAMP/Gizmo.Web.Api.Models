using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application deployments.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationDeploymentsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
