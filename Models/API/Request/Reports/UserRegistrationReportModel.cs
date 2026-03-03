using Gizmo.Web.Api.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User Registration Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserRegistrationReportModel : IWebApiModel
    {
        /// <summary>
        /// Total number of registrations in the period.
        /// </summary>
        [MessagePack.Key(0)]
        public int TotalRegistrations { get; set; }

        /// <summary>
        /// List of records for the registration chart.
        /// </summary>
        [MessagePack.Key(1)]
        public List<ChartRecordDTOModel> RegistrationChart { get; set; } = new List<ChartRecordDTOModel>();
    }

    /// <summary>
    /// User Registration Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserRegistrationReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Optional user group filter.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UserGroupId { get; set; }
    }
}
