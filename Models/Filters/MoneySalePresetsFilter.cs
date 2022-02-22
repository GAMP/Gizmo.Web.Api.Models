using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for money sale presets.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class MoneySalePresetsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
