using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

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
        [MessagePack.Key(3)]
        public int? LoginBlockBeforeTime { get; init; }

        /// <inheritdoc/>
        [NotNullIfNotNull(nameof(NextReservationId))]
        [MessagePack.Key(4)]
        public ReservationPaymentStatus? PaymentStatus { get; init; }

        /// <summary>
        /// Total amount of reservation.
        /// </summary>
        [NotNullIfNotNull(nameof(NextReservationId))]
        [MessagePack.Key(5)]
        public decimal Total { get; init; }

        /// <summary>
        /// Total outstanding amount.
        /// </summary>
        [NotNullIfNotNull(nameof(NextReservationId))]
        [MessagePack.Key(6)]
        public decimal Outstanding { get; init; }

        /// <summary>
        /// Reservation hosts.
        /// </summary>
        [MessagePack.Key(7)]
        public IEnumerable<ReservationInfoHostModel> Hosts { get; set; } = Enumerable.Empty<ReservationInfoHostModel>();
    }
}
