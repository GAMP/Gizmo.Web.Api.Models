#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task usage.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationTaskUsageModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationId { get; init; }

        /// <summary>
        /// The Id of the executable.
        /// </summary>
        [MessagePack.Key(1)]
        public int ExecutableId { get; init; }

        #endregion
    }
}
