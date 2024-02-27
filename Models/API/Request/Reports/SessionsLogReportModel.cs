using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Sessions Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SessionsLogReportModel : IWebApiModel
    {
        /// <summary>
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? UserName { get; set; }

        /// <summary>
        /// Filtered Host Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostId { get; set; }

        /// <summary>
        /// Filtered Host Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? HostName { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(5)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// List of sessions within the reporting period.
        /// </summary>
        [MessagePack.Key(6)]
        public List<UserSessionDetailsDTOModel> Sessions { get; set; } = new List<UserSessionDetailsDTOModel>();
    }

    /// <summary>
    /// Sessions Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SessionsLogReportParametersModel : IWebApiModel , IUriParametersQuery
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
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filter Host Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostId { get; set; }

        /// <summary>
        /// Filter Operator Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? OperatorId { get; set; }
    }
}
