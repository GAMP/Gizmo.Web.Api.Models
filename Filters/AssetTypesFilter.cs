using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for asset types.
    /// </summary>
    [Serializable]
    [DataContract]
    public class AssetTypesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
