using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation.
    /// </summary>
    [Serializable, MessagePack.MessagePackObject]
    public sealed class ReservationModel : IReservationModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the user this reservation is associated with.
        /// </summary>
        [MessagePack.Key(1)]
        public int? UserId { get; set; }

        /// <summary>
        /// The date of the reservation.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The duration of the reservation.
        /// </summary>
        [MessagePack.Key(3)]
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }

        /// <summary>
        /// The contact phone of the reservation.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(20)]
        public string? ContactPhone { get; set; }

        /// <summary>
        /// The contact email of the reservation.
        /// </summary>
        [MessagePack.Key(5)]
        [StringLength(254)]
        [EmailNullEmptyValidation]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// The note of the reservation.
        /// </summary>
        [MessagePack.Key(6)]
        public string? Note { get; set; }

        /// <summary>
        /// The pin of the reservation.
        /// </summary>
        [MessagePack.Key(7)]
        [StringLength(6)]
        public string Pin { get; set; } = null!;

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [MessagePack.Key(8)]
        [EnumValueValidation]
        public ReservationStatus Status { get; set; }

        /// <summary>
        /// The reserved hosts by this reservation.
        /// </summary>
        [MessagePack.Key(9)]
        public IEnumerable<ReservationModelHost> Hosts { get; set; } = Enumerable.Empty<ReservationModelHost>();

        /// <summary>
        /// The users of this reservation.
        /// </summary>
        [MessagePack.Key(10)]
        public IEnumerable<ReservationModelUser> Users { get; set; } = Enumerable.Empty<ReservationModelUser>();

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public int BranchId { get; set; }

        /// <summary>
        /// Payment status.
        /// </summary>
        [MessagePack.Key(12)]
        public ReservationPaymentStatus PaymentStatus { get; init; }

        /// <summary>
        /// Activation time.
        /// </summary>
        [MessagePack.Key(13)]
        public DateTime? ActivationTime { get; init; }

        /// <summary>
        /// Expire after time.
        /// </summary>
        [MessagePack.Key(14)]
        public int? ExpireAfter { get; init; }

        /// <summary>
        /// Cancellation grace period.
        /// </summary>
        [MessagePack.Key(15)]
        public int? CancellationGracePeriod { get; init; }

        /// <summary>
        /// Cancellation refund percentage.
        /// </summary>
        [MessagePack.Key(16)]
        public decimal CancellationRefundPercentage { get; init; }

        /// <summary>
        /// Login block before time.
        /// </summary>
        [MessagePack.Key(17)]
        public int? LoginBlockBeforeTime { get; init; }

        /// <summary>
        /// Login block after time.
        /// </summary>
        [MessagePack.Key(18)]
        public int? LoginBlockAfterTime { get; init; }

        /// <summary>
        /// Finalized by id.
        /// </summary>
        [MessagePack.Key(19)]
        public int? FinalizedById { get; init; }

        /// <summary>
        /// The time the reservation was created.
        /// </summary>
        [MessagePack.Key(20)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// The Id of the operator that created the reservation.
        /// </summary>
        [MessagePack.Key(21)]
        public int? OperatorId { get; init; }

        /// <summary>
        /// Effective order id.
        /// </summary>
        /// <remarks>Will only have value for orders expecting payments.</remarks>
        [MessagePack.Key(22)]
        public int? OrderId { get; init; }
    }
}
