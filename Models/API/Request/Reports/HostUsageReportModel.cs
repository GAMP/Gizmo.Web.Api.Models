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
        /// Filtered Host Group Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// Filtered Host Group Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? HostGroupName { get; set; }

        /// <summary>
        /// Filtered Host Usage Report Type.
        /// </summary>
        [MessagePack.Key(2)]
        public HostUsageReportTypes HostUsageReportType { get; set; }

        /// <summary>
        /// Usage information grouped by host group.
        /// </summary>
        [MessagePack.Key(3)]
        public List<HostGroupUsageInfoDTOModel> HostGroups { get; set; } = new List<HostGroupUsageInfoDTOModel>();

        /// <summary>
        /// Total hours the hosts were used within the reporting period.
        /// </summary>
        [MessagePack.Key(4)]
        public string? TotalHoursUsed { get; set; }

        /// <summary>
        /// Total estimated revenue within the reporting period.
        /// </summary>
        [MessagePack.Key(5)]
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
}
