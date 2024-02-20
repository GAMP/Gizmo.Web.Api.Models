using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host Usage Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostUsageReportModel : IWebApiModel
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
        /// Filtered Host Group Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// Filtered Host Group Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? HostGroupName { get; set; }

        /// <summary>
        /// Filtered Host Usage Report Type.
        /// </summary>
        [MessagePack.Key(7)]
        public HostUsageReportTypes HostUsageReportType { get; set; }

        /// <summary>
        /// Usage information grouped by host group.
        /// </summary>
        [MessagePack.Key(8)]
        public List<HostGroupUsageInfoModel> HostGroups { get; set; } = new List<HostGroupUsageInfoModel>();

        /// <summary>
        /// Total hours the hosts were used within the reporting period.
        /// </summary>
        [MessagePack.Key(9)]
        public string? TotalHoursUsed { get; set; }

        /// <summary>
        /// Total estimated revenue within the reporting period.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal TotalEstimatedRevenue { get; set; }
    }

    /// <summary>
    /// Host Usage Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostUsageReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Host Usage Report Type.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        public HostUsageReportTypes HostUsageReportType { get; set; }

        /// <summary>
        /// Filter Host Group Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostGroupId { get; set; }
    }

    /// <summary>
    /// Host Group Usage Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class HostGroupUsageInfoModel
    {
        /// <summary>
        /// Host group Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Host group name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? HostGroupName { get; set; }

        /// <summary>
        /// Total minutes the hosts of the group were used within the reporting period.
        /// </summary>
        [MessagePack.Key(2)]
        public long TotalMinutesUsed { get; set; }

        /// <summary>
        /// Total hours the hosts of the group were used within the reporting period.
        /// </summary>
        [MessagePack.Key(3)]
        public string? TotalHoursUsed { get; set; }

        /// <summary>
        /// Period total minutes multiplied by the number of available hosts.
        /// </summary>
        [MessagePack.Key(4)]
        public long TotalMinutes { get; set; }

        /// <summary>
        /// Total estimated revenue within the reporting period.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal TotalEstimatedRevenue { get; set; }

        /// <summary>
        /// Utilization percentage.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal UtilizationPercentage { get; set; }

        /// <summary>
        /// List of records for the estimated value per host group.
        /// </summary>
        [MessagePack.Key(7)]
        public List<GroupSessionsEstimationModel> GroupSessionsEstimations { get; set; } = new List<GroupSessionsEstimationModel>();

        /// <summary>
        /// List of records for the utilization charts.
        /// </summary>
        [MessagePack.Key(8)]
        public List<PeriodUtilizationChartRecordModel> UtilizationChart { get; set; } = new List<PeriodUtilizationChartRecordModel>();
    }

    /// <summary>
    /// Group Sessions Estimation.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class GroupSessionsEstimationModel
    {
        /// <summary>
        /// Group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// The time the session was running as text.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Duration { get; set; }

        /// <summary>
        /// Duration of the user session in minutes.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal TotalMinutes { get; set; }

        /// <summary>
        /// Hours used percentage in comparison with other groups within the same period.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal HoursPercentage { get; set; }

        /// <summary>
        /// Packet minutes.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Packet cost.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Value { get; set; }

        /// <summary>
        /// Estimated revenue percentage in comparison with other groups within the same period.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal EstimatedRevenuePercentage { get; set; }

        [MessagePack.Key(7)]
        public List<GroupSessionsEstimationModel>? SubGroupSessionsEstimations { get; set; }
    }
}
