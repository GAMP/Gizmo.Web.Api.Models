using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Top Users Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TopUsersReportModel : IWebApiModel
    {
        /// <summary>
        /// Filtered number of top users to display.
        /// </summary>
        [MessagePack.Key(0)]
        public int TopUsersNumber { get; set; }

        /// <summary>
        /// Member counters.
        /// </summary>
        [MessagePack.Key(1)]
        public MemberCountersDTOModel MemberCounters { get; set; } = new MemberCountersDTOModel();

        /// <summary>
        /// List of top spenders grouped by user group.
        /// </summary>
        [MessagePack.Key(2)]
        public List<TopUsersReportUserGroupDTOModel> TopSpenders { get; set; } = new List<TopUsersReportUserGroupDTOModel>();

        /// <summary>
        /// List of top point earners grouped by user group.
        /// </summary>
        [MessagePack.Key(3)]
        public List<TopUsersReportUserGroupDTOModel> TopPointEarners { get; set; } = new List<TopUsersReportUserGroupDTOModel>();

        /// <summary>
        /// List of top point spenders grouped by user group.
        /// </summary>
        [MessagePack.Key(4)]
        public List<TopUsersReportUserGroupDTOModel> TopPointSpenders { get; set; } = new List<TopUsersReportUserGroupDTOModel>();

        /// <summary>
        /// List of top users based on total usage time grouped by user group.
        /// </summary>
        [MessagePack.Key(5)]
        public List<TopUsersReportUserGroupDTOModel> TopSessions { get; set; } = new List<TopUsersReportUserGroupDTOModel>();

        /// <summary>
        /// List of top users based on longest session grouped by user group.
        /// </summary>
        [MessagePack.Key(6)]
        public List<TopUsersReportUserGroupDTOModel> TopSessionDuration { get; set; } = new List<TopUsersReportUserGroupDTOModel>();
    }

    /// <summary>
    /// Top Users Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TopUsersReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter number of top users to display.
        /// </summary>
        [MessagePack.Key(3)]
        [Required]
        public int TopUsersNumber { get; set; }
    }
}
