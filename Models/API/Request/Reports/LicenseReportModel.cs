using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicenseReportModel : IWebApiModel
    {
        /// <summary>
        /// Report Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

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
        public string? CompanyName { get; set; }

        ///// <summary>
        ///// Report Type.
        ///// </summary>
        //[MessagePack.Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered License Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? LicenseId { get; set; }

        /// <summary>
        /// Filtered License Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string LicenseName { get; set; }

        /// <summary>
        /// License usage information.
        /// </summary>
        [MessagePack.Key(7)]
        public LicenseUsageInfoDTO LicenseUsage { get; set; }

        /// <summary>
        /// List of records for the concurrent keys chart.
        /// </summary>
        [MessagePack.Key(8)]
        public List<ChartRecordDTO> LicenseTimeChart { get; set; }
    }

    /// <summary>
    /// Licenses Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicenseReportParametersModel : IWebApiModel, IUriParametersQuery
    {
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
        /// Filter License Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int LicenseId { get; set; }
    }
}
