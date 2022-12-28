﻿namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Product tax.
    /// </summary>
    public interface IProductTaxApiModel
    {
        /// <summary>
        /// Indicates if product tax is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Tax id.
        /// </summary>
        int TaxId { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        int UseOrder { get; set; }
    }
}