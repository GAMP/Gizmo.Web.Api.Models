using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application stat model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AppStatModel : IApplicationStatModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int HostId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int AppId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int AppExeId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public DateTime StartTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public double Span { get; init; }
    }
}
