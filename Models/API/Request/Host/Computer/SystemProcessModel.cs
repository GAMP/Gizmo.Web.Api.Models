using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// System process model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemProcessModel : IWebApiModel
    {
        /// <summary>
        /// Process id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProcessId { get; init; }

        /// <summary>
        /// Parent process id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ParentId { get; init; }

        /// <summary>
        /// Process name.
        /// </summary>
        [MessagePack.Key(2)]
        public string? ProcessName { get; init; }

        /// <summary>
        /// Working directory.
        /// </summary>
        [MessagePack.Key(3)]
        public string? WorkingDirectory { get; init; }

        /// <summary>
        /// Command line.
        /// </summary>
        [MessagePack.Key(4)]
        public string? CommandLine { get; init; }

        /// <summary>
        /// Start time.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime? StartTime { get; init; }

        /// <summary>
        /// Session id.
        /// </summary>
        [MessagePack.Key(6)]
        public int SessionId { get; init; }

        /// <summary>
        /// Cpu usage.
        /// </summary>
        [MessagePack.Key(7)]
        public double CpuUsage { get; init; }
    }
}
