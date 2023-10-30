using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LogModel : ILogModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime Time { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostNumber { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public string? Hostname { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(4)]
        public string Message { get; init; } = string.Empty;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(5)]
        public LogCategory Category { get;init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(6)]
        public ModuleType ModuleType { get; init; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(7)]
        public string? ModuleVersion { get; init; }
    }
}
