using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for variables.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class VariablesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
