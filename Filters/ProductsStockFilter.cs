﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for products stock.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductsStockFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
