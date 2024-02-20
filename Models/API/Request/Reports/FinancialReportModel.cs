using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Financial Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FinancialReportModel : IWebApiModel
    {
    }

    /// <summary>
    /// Financial Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FinancialReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Operator Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filter Register Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filter Financial Report Type.
        /// </summary>
        [MessagePack.Key(4)]
        [Required]
        public FinancialReportTypes FinancialReportType { get; set; }
    }
}
