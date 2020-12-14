using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for assets.
    /// </summary>
    [Serializable]
    [DataContract]
    public class AssetsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
