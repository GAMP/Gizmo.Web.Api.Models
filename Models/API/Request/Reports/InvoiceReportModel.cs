using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoiceReportModel : IWebApiModel
    {
        /// <summary>
        /// Report Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Date From.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filtered Date To.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Company Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string CompanyName { get; set; } = string.Empty;

        ///// <summary>
        ///// Report Type.
        ///// </summary>
        //[MessagePack.Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered Invoice Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Information of the invoice.
        /// </summary>
        [MessagePack.Key(6)]
        public InvoiceDTOModel Invoice { get; set; }

        /// <summary>
        /// List of products sold with this invoice.
        /// </summary>
        [MessagePack.Key(7)]
        public List<SoldProductDTOModel> SoldProducts { get; set; } = new List<SoldProductDTOModel>();

        /// <summary>
        /// List of payments performed for this invoice.
        /// </summary>
        [MessagePack.Key(8)]
        public List<InvoicePaymentDTOModel> Payments { get; set; } = new List<InvoicePaymentDTOModel>();

        /// <summary>
        /// List of refunds performed for this invoice.
        /// </summary>
        [MessagePack.Key(9)]
        public List<RefundDTOModel> Refunds { get; set; } = new List<RefundDTOModel>();
    }

    /// <summary>
    /// Invoice Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoiceReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// Filter Date From.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filter Date To.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Filter Invoice Id.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        public int InvoiceId { get; set; }

        #endregion
    }
}
