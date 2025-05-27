using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Tasks counters.
    /// </summary>
    [MessagePackObject]
    public sealed class TaskCountersModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the task.
        /// </summary>
        [MessagePack.Key(1)]
        public TaskType Type { get; set; }

        /// <summary>
        /// Number of executables that use this task.
        /// </summary>
        [MessagePack.Key(2)]
        public int UsedByExecutables { get; set; }

        /// <summary>
        /// Shell triggers that use this task.
        /// </summary>
        [MessagePack.Key(3)]
        public ClientTaskActivationType ShellTriggers { get; set; }
    }
}
