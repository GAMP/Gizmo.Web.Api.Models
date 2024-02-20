namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application Information.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ApplicationInfoModel
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
