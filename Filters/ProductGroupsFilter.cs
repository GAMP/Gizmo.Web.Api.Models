using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for product groups.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
