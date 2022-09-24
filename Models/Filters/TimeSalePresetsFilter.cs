using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for time sale presets.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeSalePresetsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
