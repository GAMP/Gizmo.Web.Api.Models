using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationReportModel : IWebApiModel
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
        //[Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Application Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Filtered Application Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Application information.
        /// </summary>
        [MessagePack.Key(9)]
        public ApplicationInfoDTOModel Application { get; set; }

        /// <summary>
        /// List of executables that belongs to the application and ran within the reporting period.
        /// </summary>
        [MessagePack.Key(10)]
        public List<ExecutableExecutionSummaryDTOModel> Executables { get; set; } = new List<ExecutableExecutionSummaryDTOModel>();

        /// <summary>
        /// List of records for the runtime per user group chart.
        /// </summary>
        [MessagePack.Key(11)]
        public List<ChartGroupDTOModel> HoursPerUserGroupChart { get; set; } = new List<ChartGroupDTOModel>();

        /// <summary>
        /// List of records for the runtime per host group chart.
        /// </summary>
        [MessagePack.Key(12)]
        public List<ChartGroupDTOModel> HoursPerHostGroupChart { get; set; } = new List<ChartGroupDTOModel>();
    }

    /// <summary>
    /// Application Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Application Id.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? UserId { get; set; }

        #endregion
    }    
}
