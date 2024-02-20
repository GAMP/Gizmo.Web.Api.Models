using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Sessions Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SessionsLogReportModel : IWebApiModel
    {
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
