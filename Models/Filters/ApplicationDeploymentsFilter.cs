using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application deployments.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationDeploymentsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return deployments with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string DeploymentName { get; set; }
    }
}
