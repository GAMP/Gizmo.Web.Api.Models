using Gizmo.Web.Api.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Overview Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportModel : IWebApiModel
    {
        /// <summary>
        /// List of operator statistics.
        /// </summary>
        [MessagePack.Key(0)]
        public List<OverviewReportOperatorStatisticsDTOModel> OperatorsStatistics { get; set; } = new List<OverviewReportOperatorStatisticsDTOModel>();

        /// <summary>
        /// Average daily member visits duration.
        /// </summary>
        [MessagePack.Key(1)]
        public string? AverageMemberUsagePeriodMinutes { get; set; }

        /// <summary>
        /// Average daily guest visits duration.
        /// </summary>
        [MessagePack.Key(2)]
        public string? AverageGuestUsagePeriodMinutes { get; set; }

        /// <summary>
        /// Average utilization percentage.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal AverageUtilizationPercentage { get; set; }

        /// <summary>
        /// Unique members logins.
        /// </summary>
        [MessagePack.Key(4)]
        public int UniqueMembersLogins { get; set; }

        /// <summary>
        /// Unique guests logins.
        /// </summary>
        [MessagePack.Key(5)]
        public int UniqueGuestsLogins { get; set; }

        /// <summary>
        /// Member counters.
        /// </summary>
        [MessagePack.Key(6)]
        public MemberCountersDTOModel MemberCounters { get; set; } = new MemberCountersDTOModel();

        /// <summary>
        /// List of records for the utilization chart.
        /// </summary>
        [MessagePack.Key(7)]
        public List<PeriodUtilizationChartRecordDTOModel> UtilizationChart { get; set; } = new List<PeriodUtilizationChartRecordDTOModel>();

        /// <summary>
        /// List of records for the financial chart.
        /// </summary>
        [MessagePack.Key(8)]
        public List<ChartRecordDTOModel> FinancialChart { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// Total pay in-out.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal TotalPayInOut { get; set; }

        /// <summary>
        /// Total revenue.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal TotalRevenue { get; set; }

        /// <summary>
        /// Average revenue per member.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal AverageRevenuePerMember { get; set; }

        /// <summary>
        /// Average revenue per guest.
        /// </summary>
        [MessagePack.Key(12)]
        public decimal AverageRevenuePerGuest { get; set; }

        /// <summary>
        /// List of user group revenue.
        /// </summary>
        [MessagePack.Key(13)]
        public List<NamedDecimalContainerDTOModel> RevenuePerGroup { get; set; } = new List<NamedDecimalContainerDTOModel>();
    }

    /// <summary>
    /// Overview Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportParametersModel : IWebApiModel, IUriParametersQuery
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
    }
}
