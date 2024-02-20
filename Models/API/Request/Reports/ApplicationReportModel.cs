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
        public ApplicationInfoModel Application { get; set; }

        /// <summary>
        /// List of executables that belongs to the application and ran within the reporting period.
        /// </summary>
        [MessagePack.Key(10)]
        public List<ExecutableExecutionSummaryDTO> Executables { get; set; } = new List<ExecutableExecutionSummaryDTO>();

        /// <summary>
        /// List of records for the runtime per user group chart.
        /// </summary>
        [MessagePack.Key(11)]
        public List<ChartGroupDTO> HoursPerUserGroupChart { get; set; } = new List<ChartGroupDTO>();

        /// <summary>
        /// List of records for the runtime per host group chart.
        /// </summary>
        [MessagePack.Key(12)]
        public List<ChartGroupDTO> HoursPerHostGroupChart { get; set; } = new List<ChartGroupDTO>();
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

    /// <summary>
    /// Executable Execution Summary.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ExecutableExecutionSummaryDTO
    {
        /// <summary>
        /// Executable Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ExecutableId { get; set; }

        /// <summary>
        /// Executable name.
        /// </summary>
        [MessagePack.Key(1)]
        public string ExecutableName { get; set; }

        /// <summary>
        /// The number of unique users who ran the executable.
        /// </summary>
        [MessagePack.Key(2)]
        public int UniqueUsers { get; set; }

        /// <summary>
        /// Total number of runs.
        /// </summary>
        [MessagePack.Key(3)]
        public int TotalExecutions { get; set; }

        /// <summary>
        /// Total seconds the executable was running.
        /// </summary>
        [MessagePack.Key(4)]
        public double TotalSeconds { get; set; }

        /// <summary>
        /// Total time the executable was running as text.
        /// </summary>
        [MessagePack.Key(5)]
        public string TotalTime { get; set; }

        /// <summary>
        /// Average daily run time.
        /// </summary>
        [MessagePack.Key(6)]
        public string AverageDailyExecutionTime { get; set; }
    }

    /// <summary>
    /// Chart Group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ChartGroupDTO
    {
        /// <summary>
        /// Chart group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// List of records for the group.
        /// </summary>
        [MessagePack.Key(1)]
        public List<ChartRecordDTO> GroupRecords { get; set; }
    }

    /// <summary>
    /// Chart Record.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ChartRecordDTO
    {
        /// <summary>
        /// The name of the chart record.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the chart record.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Value { get; set; }
    }
}
