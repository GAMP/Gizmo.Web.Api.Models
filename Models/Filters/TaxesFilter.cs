using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for taxes.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TaxesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
