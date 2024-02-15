using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportModel : IWebApiModel
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
        public string AverageGuestUsagePeriodMinutes { get; set; } = string.Empty;

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

    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        [MessagePack.Key(0)]
        public DateTime DateFrom { get; set; }

        [MessagePack.Key(1)]
        public DateTime DateTo { get; set; }
    }

    /// <summary>
    /// Overview Report Operator Statistics.
    /// </summary>
    [MessagePackObject]
    public class OverviewReportOperatorStatisticsModel
    {
        /// <summary>
        /// Operator Id.
        /// </summary>
        [Key(0)]
        public int OperatorId { get; set; }

        /// <summary>
        /// Operator name.
        /// </summary>
        [Key(1)]
        public string OperatorName { get; set; } = string.Empty;

        /// <summary>
        /// Total minutes the operator worked.
        /// </summary>
        [Key(2)]
        public int MinutesWorked { get; set; }

        /// <summary>
        /// Total hours the operator worked as text.
        /// </summary>
        [Key(3)]
        public string HoursWorked { get; set; } = string.Empty;

        /// <summary>
        /// Total minutes the operator sold.
        /// </summary>
        [Key(4)]
        public decimal MinutesSold { get; set; }

        /// <summary>
        /// Total hours the operator sold as text.
        /// </summary>
        [Key(5)]
        public string HoursSold { get; set; } = string.Empty;

        /// <summary>
        /// Number of products the operator sold.
        /// </summary>
        [Key(6)]
        public decimal ProductsSold { get; set; }

        /// <summary>
        /// Number of time offers the operator sold.
        /// </summary>
        [Key(7)]
        public decimal TimeOffersSold { get; set; }

        /// <summary>
        /// Number of bundles the operator sold.
        /// </summary>
        [Key(8)]
        public decimal BundlesSold { get; set; }

        /// <summary>
        /// Number of voids the operator performed.
        /// </summary>
        [Key(9)]
        public int Voids { get; set; }

        /// <summary>
        /// Total amount of register transactions performed by the operator.
        /// </summary>
        [Key(10)]
        public decimal RegisterTransactionsTotal { get; set; }

        /// <summary>
        /// Operator revenue.
        /// </summary>
        [Key(11)]
        public decimal Revenue { get; set; }
    }

    /// <summary>
    /// Member Counters.
    /// </summary>
    [MessagePackObject]
    public class MemberCountersModel
    {
        /// <summary>
        /// Number of new members.
        /// </summary>
        [Key(0)]
        public int NewMembers { get; set; }

        /// <summary>
        /// Total number of members.
        /// </summary>
        [Key(1)]
        public int TotalMembers { get; set; }

        /// <summary>
        /// Number of banned members.
        /// </summary>
        [Key(2)]
        public int BannedMembers { get; set; }
    }

    /// <summary>
    /// An object containing a name and a decimal value.
    /// </summary>
    [MessagePackObject]
    public class NamedDecimalContainerModel
    {
        /// <summary>
        /// Name of the object.
        /// </summary>
        [Key(0)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Value of the object.
        /// </summary>
        [Key(1)]
        public decimal Value { get; set; }
    }

    /// <summary>
    /// Chart Record.
    /// </summary>
    [MessagePackObject]
    public class ChartRecordModel
    {
        /// <summary>
        /// The name of the chart record.
        /// </summary>
        [Key(0)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The value of the chart record.
        /// </summary>
        [Key(1)]
        public decimal Value { get; set; }
    }
}
