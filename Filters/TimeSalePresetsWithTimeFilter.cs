using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for time sale presets with time.
    /// </summary>
    [Serializable]
    [DataContract]
    public class TimeSalePresetsWithTimeFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
