using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shifts Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftsLogReportModel : IWebApiModel
    {
        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// Filtered Shifts Log Report Types.
        /// </summary>
        [MessagePack.Key(4)]
        public ShiftsLogReportTypes ShiftsLogReportType { get; set; }

        /// <summary>
        /// Report Shifts.
        /// </summary>
        [MessagePack.Key(5)]
        public List<ShiftDTOModel> Shifts { get; set; } = new List<ShiftDTOModel>();

        /// <summary>
        /// Total amount expected the active shifts to end with excluding start cash.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal? TotalExpectedExcludingStartCashActive { get; set; }

        /// <summary>
        /// Total duration of the shifts as text.
        /// </summary>
        [MessagePack.Key(7)]
        public string? TotalDuration { get; set; }

        /// <summary>
        /// Total amount expected the shifts to end with excluding start cash.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal? TotalExpectedExcludingStartCash { get; set; }

        /// <summary>
        /// Total difference between the expected and the actual amount.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal? TotalDifference { get; set; }
    }

    /// <summary>
    /// Shifts Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftsLogReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Shifts Log Report Type.
        /// </summary>
        [MessagePack.Key(4)]
        [Required]
        public ShiftsLogReportTypes ShiftsLogReportType { get; set; }
    }
}
