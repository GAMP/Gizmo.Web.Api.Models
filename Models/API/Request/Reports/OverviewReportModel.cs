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
        /// List of operator statistics.
        /// </summary>
        [MessagePack.Key(5)]
        public List<OverviewReportOperatorStatisticsModel> OperatorsStatistics { get; set; } = new List<OverviewReportOperatorStatisticsModel>();

        /// <summary>
        /// Average daily member visits duration.
        /// </summary>
        [MessagePack.Key(6)]
        public string AverageMemberUsagePeriodMinutes { get; set; } = string.Empty;

        /// <summary>
        /// Average daily guest visits duration.
        /// </summary>
        [MessagePack.Key(7)]
        public string? AverageGuestUsagePeriodMinutes { get; set; }

        /// <summary>
        /// Average utilization percentage.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal AverageUtilizationPercentage { get; set; }

        /// <summary>
        /// Unique members logins.
        /// </summary>
        [MessagePack.Key(9)]
        public int UniqueMembersLogins { get; set; }

        /// <summary>
        /// Unique guests logins.
        /// </summary>
        [MessagePack.Key(10)]
        public int UniqueGuestsLogins { get; set; }

        /// <summary>
        /// Member counters.
        /// </summary>
        [MessagePack.Key(11)]
        public MemberCountersModel MemberCounters { get; set; } = new MemberCountersModel();

        /// <summary>
        /// List of records for the utilization chart.
        /// </summary>
        [MessagePack.Key(12)]
        public List<PeriodUtilizationChartRecordModel> UtilizationChart { get; set; } = new List<PeriodUtilizationChartRecordModel>();

        /// <summary>
        /// List of records for the financial chart.
        /// </summary>
        [MessagePack.Key(13)]
        public List<ChartRecordModel> FinancialChart { get; set; } = new List<ChartRecordModel>();

        /// <summary>
        /// Total pay in-out.
        /// </summary>
        [MessagePack.Key(14)]
        public decimal TotalPayInOut { get; set; }

        /// <summary>
        /// Total revenue.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal TotalRevenue { get; set; }

        /// <summary>
        /// Average revenue per member.
        /// </summary>
        [MessagePack.Key(16)]
        public decimal AverageRevenuePerMember { get; set; }

        /// <summary>
        /// Average revenue per guest.
        /// </summary>
        [MessagePack.Key(17)]
        public decimal AverageRevenuePerGuest { get; set; }

        /// <summary>
        /// List of user group revenue.
        /// </summary>
        [MessagePack.Key(18)]
        public List<NamedDecimalContainerModel> RevenuePerGroup { get; set; } = new List<NamedDecimalContainerModel>();
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
