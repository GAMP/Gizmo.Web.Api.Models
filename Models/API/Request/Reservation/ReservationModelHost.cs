using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation Host.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ReservationModelHost
    {
        /// <summary>
        /// The Id of the host.
        /// </summary>
        [Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Status.
        /// </summary>
        [Key(1)]
        public ReservationStatus Status { get; init; }

        /// <summary>
        /// Moved host id.
        /// </summary>
        [Key(2)]
        public int? MovedHostId { get; init; }

        /// <summary>
        /// Activation time.
        /// </summary>
        [Key(3)]
        public DateTime? ActivationTime { get; init; }

        /// <summary>
        /// Finalized by id.
        /// </summary>
        [Key(4)]
        public int? FinalizedById { get; init; }
    }
}
