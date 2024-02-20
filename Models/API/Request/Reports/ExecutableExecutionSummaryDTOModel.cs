namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Executable Execution Summary.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ExecutableExecutionSummaryDTOModel
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
}
