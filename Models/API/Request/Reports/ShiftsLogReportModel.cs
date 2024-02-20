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
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// Filtered Shifts Log Report Types.
        /// </summary>
        [MessagePack.Key(9)]
        public ShiftsLogReportTypes ShiftsLogReportType { get; set; }

        /// <summary>
        /// Report Shifts.
        /// </summary>
        [MessagePack.Key(10)]
        public List<ShiftDTOModel> Shifts { get; set; }

        /// <summary>
        /// Total amount expected the active shifts to end with excluding start cash.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal? TotalExpectedExcludingStartCashActive { get; set; }

        /// <summary>
        /// Total duration of the shifts as text.
        /// </summary>
        [MessagePack.Key(12)]
        public string? TotalDuration { get; set; }

        /// <summary>
        /// Total amount expected the shifts to end with excluding start cash.
        /// </summary>
        [MessagePack.Key(13)]
        public decimal? TotalExpectedExcludingStartCash { get; set; }

        /// <summary>
        /// Total difference between the expected and the actual amount.
        /// </summary>
        [MessagePack.Key(14)]
        public decimal? TotalDifference { get; set; }
    }

    /// <summary>
    /// Shifts Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftsReportParametersModel : IWebApiModel, IUriParametersQuery
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

    /// <summary>
    /// Shift Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftDTOModel
    {
        /// <summary>
        /// Shift Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ShiftId { get; set; }

        /// <summary>
        /// The shift is active.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Cash amount the shift started with.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// The Id of the register on which the shift was started.
        /// </summary>
        [MessagePack.Key(3)]
        public int RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the shift was started.
        /// </summary>
        [MessagePack.Key(4)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The name of the operator to which the shift belongs.
        /// </summary>
        [MessagePack.Key(5)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The name of the operator who ended the shift.
        /// </summary>
        [MessagePack.Key(6)]
        public string? EndedByOperatorName { get; set; }

        /// <summary>
        /// The time the shift started.
        /// </summary>
        [MessagePack.Key(7)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time the shift ended or null if is still active.
        /// </summary>
        [MessagePack.Key(8)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Duration of the shift in minutes.
        /// </summary>
        [MessagePack.Key(9)]
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Duration of the shift as text.
        /// </summary>
        [MessagePack.Key(10)]
        public string? Duration { get; set; }

        /// <summary>
        /// Amount expected the shift to end with.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal Expected { get; set; }

        /// <summary>
        /// Actual amount the shift ended with.
        /// </summary>
        [MessagePack.Key(12)]
        public decimal? Actual { get; set; }

        /// <summary>
        /// Difference between the expected and the actual amount.
        /// </summary>
        [MessagePack.Key(13)]
        public decimal? Difference { get; set; }

        /// <summary>
        /// Total amount of sales in this shift.
        /// </summary>
        [MessagePack.Key(14)]
        public decimal Sales { get; set; }

        /// <summary>
        /// Total amount of deposits in this shift.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal Deposits { get; set; }

        /// <summary>
        /// Total amount of withdrawals in this shift.
        /// </summary>
        [MessagePack.Key(16)]
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// Total amount of refunds in this shift.
        /// </summary>
        [MessagePack.Key(17)]
        public decimal Refunds { get; set; }

        /// <summary>
        /// List of shift details by payment method.
        /// </summary>
        [MessagePack.Key(18)]
        public List<ShiftDetailsDTOModel> Details { get; set; } = new List<ShiftDetailsDTOModel>();
    }

    /// <summary>
    /// Shift Details.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftDetailsDTOModel
    {
        /// <summary>
        /// Payment method name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? PaymentMethodName { get; set; }

        /// <summary>
        /// Cash amount the shift started with for this payment method.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// Total amount of sales in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Sales { get; set; }

        /// <summary>
        /// Total amount of deposits in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Deposits { get; set; }

        /// <summary>
        /// Total amount of withdrawals in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// Total amount of refunds in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Refunds { get; set; }

        /// <summary>
        /// Total amount of pay ins in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal PayIns { get; set; }

        /// <summary>
        /// Total amount of pay outs in this shift for this payment method.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal PayOuts { get; set; }

        /// <summary>
        /// Amount expected the shift to end with for this payment method.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Expected { get; set; }

        /// <summary>
        /// Actual amount the shift ended with for this payment method.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Actual { get; set; }

        /// <summary>
        /// Difference between the expected and the actual amount for this payment method.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal Difference { get; set; }

    }
}
