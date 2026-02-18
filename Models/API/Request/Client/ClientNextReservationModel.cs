using System;
using System.Diagnostics.CodeAnalysis;

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
        [NotNullIfNotNull(nameof(NextReservationId))]
        [MessagePack.Key(1)]
        public DateTime? NextReservationTime { get; init; }

        /// <inheritdoc/>
        [NotNullIfNotNull(nameof(NextReservationId))]
        [MessagePack.Key(2)]
        public int? Duration { get; init; }

        /// <inheritdoc/>
        [NotNullIfNotNull(nameof(NextReservationId))]
        [MessagePack.Key(4)]
        public int? LoginBlockBeforeTime { get; init; }
    }
}
