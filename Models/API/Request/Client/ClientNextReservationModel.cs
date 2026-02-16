using System;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IClientNextReservationModel"/>
    [MessagePack.MessagePackObject]
    public sealed class ClientNextReservationModel : IClientNextReservationModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int? NextReservationId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public DateTime? NextReservationTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int? Duration { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int? LoginBlockBeforeTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int? LoginBlockAfterTime { get; init; }
    }
}
