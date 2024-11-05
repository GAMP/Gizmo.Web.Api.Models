using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application stat create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AppStatCreateModel: IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId { get; init; }

        /// <summary>
        /// Start time.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime StartTime { get; init; }

        /// <summary>
        /// Span.
        /// </summary>
        [MessagePack.Key(4)]
        public double Span { get; init; }
    }
}
