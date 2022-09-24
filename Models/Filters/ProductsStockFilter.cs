using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for products stock.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductsStockFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
