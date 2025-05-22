using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [MessagePackObject]
    public sealed class V3ApplicationExecutableTaskModelCreate : IV3ApplicationExecutableTaskModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the task associated with this application executable.
        /// </summary>
        [Key(0)]
        public int TaskId { get; set; }

        /// <summary>
        /// Executable task activation type.
        /// </summary>
        [Key(1)]
        public ExecutableTaskActivationType Activation { get; set; }

        /// <summary>
        /// The order in which the task is used.
        /// </summary>
        [Key(2)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Whether the executable is enabled.
        /// </summary>
        [Key(3)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}
