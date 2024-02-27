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
        /// Filtered License Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? LicenseId { get; set; }

        /// <summary>
        /// Filtered License Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? LicenseName { get; set; }

        /// <summary>
        /// License usage information.
        /// </summary>
        [MessagePack.Key(2)]
        public LicenseUsageInfoDTOModel LicenseUsage { get; set; } = new LicenseUsageInfoDTOModel();

        /// <summary>
        /// List of records for the concurrent keys chart.
        /// </summary>
        [MessagePack.Key(3)]
        public List<ChartRecordDTOModel> LicenseTimeChart { get; set; } = new List<ChartRecordDTOModel>();
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
