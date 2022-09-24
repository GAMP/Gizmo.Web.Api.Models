using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for host icons.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostIconsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
