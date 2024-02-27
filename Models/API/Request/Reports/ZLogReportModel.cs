using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Z Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ZLogReportModel : IWebApiModel
    {
        /// <summary>
        /// List of Z within the report.
        /// </summary>
        [MessagePack.Key(0)]
        public List<ZDTOModel> Zs = new List<ZDTOModel>();
    }

    /// <summary>
    /// Z Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ZLogReportParametersModel : IWebApiModel, IUriParametersQuery
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
