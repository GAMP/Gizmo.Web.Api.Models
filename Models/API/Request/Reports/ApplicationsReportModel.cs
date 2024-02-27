using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Applications Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationsReportModel : IWebApiModel
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
        /// List of applications that ran within the reporting period.
        /// </summary>
        [MessagePack.Key(2)]
        public List<ApplicationInfoDTOModel> Applications { get; set; } = new List<ApplicationInfoDTOModel>();
    }

    /// <summary>
    /// Applications Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationsReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        #region PROPERTIES

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
        /// Hide unused applications.
        /// </summary>
        [MessagePack.Key(3)]
        public bool HideUnused { get; set; }

        #endregion
    }
}
