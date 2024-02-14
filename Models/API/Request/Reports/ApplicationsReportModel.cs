using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationsReportModel : IWebApiModel
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
        /// List of applications that ran within the reporting period.
        /// </summary>
        [MessagePack.Key(7)]
        public List<ApplicationInfoModel> Applications { get; set; } = new List<ApplicationInfoModel>();
    }

    [MessagePack.MessagePackObject()]
    public sealed class ApplicationsReportParametersModel : IWebApiModel, IUriParametersQuery
    {

    }

    /// <summary>
    /// Application Information.
    /// </summary>
    [MessagePack.MessagePackObject]
    public class ApplicationInfoModel
    {
        /// <summary>
        /// Application Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Application name.
        /// </summary>
        [MessagePack.Key(1)]
        public string ApplicationName { get; set; } = string.Empty;

        /// <summary>
        /// The number of unique users who ran the application.
        /// </summary>
        [MessagePack.Key(2)]
        public int UniqueUsers { get; set; }

        /// <summary>
        /// The number of unique sessions in which the application ran.
        /// </summary>
        [MessagePack.Key(3)]
        public int UniqueSessions { get; set; }

        /// <summary>
        /// Number of total runs.
        /// </summary>
        [MessagePack.Key(4)]
        public int TotalExecutions { get; set; }

        /// <summary>
        /// Total seconds the application was running.
        /// </summary>
        [MessagePack.Key(5)]
        public double TotalSeconds { get; set; }

        /// <summary>
        /// Total time the application was running as text.
        /// </summary>
        [MessagePack.Key(6)]
        public string TotalTime { get; set; } = string.Empty;

        /// <summary>
        /// Run time percentage in comparison with other applications within the same period.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal TotalExecutionsPercentage { get; set; }

        /// <summary>
        /// Average daily run time as text.
        /// </summary>
        [MessagePack.Key(8)]
        public string AverageDailyExecutionTime { get; set; } = string.Empty;
    }
}
