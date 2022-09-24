using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for money sale presets.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MoneySalePresetsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
