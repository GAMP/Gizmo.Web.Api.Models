namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Executable Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ExecutableInfoDTOModel
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
        public string? ApplicationName { get; set; }

        /// <summary>
        /// Executable Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int ExecutableId { get; set; }

        /// <summary>
        /// Executable name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? ExecutableName { get; set; }

        /// <summary>
        /// Total seconds the executable was running.
        /// </summary>
        [MessagePack.Key(4)]
        public double TotalSeconds { get; set; }

        /// <summary>
        /// Total time the executable was running as text.
        /// </summary>
        [MessagePack.Key(5)]
        public string? TotalTime { get; set; }
    }
}
