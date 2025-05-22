namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    public interface IV3ApplicationExecutableTaskModel : IWebApiModel
    {
        /// <summary>
        /// Whether the executable task is enabled.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Executable task activation type.
        /// </summary>
        ExecutableTaskActivationType Activation { get; set; }

        /// <summary>
        /// The Id of the task associated with this application executable.
        /// </summary>
        int TaskId { get; set; }

        /// <summary>
        /// The order in which the task is used.
        /// </summary>
        int UseOrder { get; set; }
    }
}
