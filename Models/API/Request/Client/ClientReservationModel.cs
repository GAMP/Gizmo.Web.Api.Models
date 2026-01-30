using System;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [MessagePack.MessagePackObject]
    public sealed class ClientReservationModel : IClientReservationModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int? NextReservationId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public DateTime? NextReservationTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public bool EnableLoginBlock { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int LoginBlockTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public bool EnableLoginUnblock { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public int LoginUnblockTime { get; init; }
    }
}
