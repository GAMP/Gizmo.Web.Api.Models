using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Executable Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ExecutableInfoDTO
    {
        /// <summary>
        /// The Id of the application on which the executable belongs.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The name of the application on which the executable belongs.
        /// </summary>
        [MessagePack.Key(1)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Executable Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int ExecutableId { get; set; }

        /// <summary>
        /// Executable name.
        /// </summary>
        [MessagePack.Key(3)]
        public string ExecutableName { get; set; }

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
        /// List of executable runs.
        /// </summary>
        [MessagePack.Key(6)]
        public List<ExecutableExecutionInfoDTO> Executions { get; set; } = new List<ExecutableExecutionInfoDTO>();

        /// <summary>
        /// The number of unique users who ran the executable.
        /// </summary>
        [MessagePack.Key(7)]
        public int UniqueUsers { get; set; }

        /// <summary>
        /// The number of unique session in which the executable ran.
        /// </summary>
        [MessagePack.Key(8)]
        public int UniqueSessions { get; set; }

        /// <summary>
        /// Total number of runs.
        /// </summary>
        [MessagePack.Key(9)]
        public int TotalExecutions { get; set; }

        /// <summary>
        /// Average daily run time.
        /// </summary>
        [MessagePack.Key(10)]
        public string AverageDailyExecutionTime { get; set; }
    }
}
