using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for taxes.
    /// </summary>
    [Serializable]
    [DataContract]
    public class TaxesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
