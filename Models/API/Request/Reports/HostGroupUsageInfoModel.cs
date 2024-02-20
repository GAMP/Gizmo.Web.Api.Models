using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
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
}
