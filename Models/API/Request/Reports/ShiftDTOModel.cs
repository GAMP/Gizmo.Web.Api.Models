using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftDTOModel
    {
        /// <summary>
        /// Shift Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ShiftId { get; set; }

        /// <summary>
        /// The shift is active.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Cash amount the shift started with.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal StartCash { get; set; }

        /// <summary>
        /// The Id of the register on which the shift was started.
        /// </summary>
        [MessagePack.Key(3)]
        public int RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the shift was started.
        /// </summary>
        [MessagePack.Key(4)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The name of the operator to which the shift belongs.
        /// </summary>
        [MessagePack.Key(5)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The name of the operator who ended the shift.
        /// </summary>
        [MessagePack.Key(6)]
        public string? EndedByOperatorName { get; set; }

        /// <summary>
        /// The time the shift started.
        /// </summary>
        [MessagePack.Key(7)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time the shift ended or null if is still active.
        /// </summary>
        [MessagePack.Key(8)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Duration of the shift in minutes.
        /// </summary>
        [MessagePack.Key(9)]
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Duration of the shift as text.
        /// </summary>
        [MessagePack.Key(10)]
        public string? Duration { get; set; }

        /// <summary>
        /// Amount expected the shift to end with.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal Expected { get; set; }

        /// <summary>
        /// Actual amount the shift ended with.
        /// </summary>
        [MessagePack.Key(12)]
        public decimal? Actual { get; set; }

        /// <summary>
        /// Difference between the expected and the actual amount.
        /// </summary>
        [MessagePack.Key(13)]
        public decimal? Difference { get; set; }

        /// <summary>
        /// Total amount of sales in this shift.
        /// </summary>
        [MessagePack.Key(14)]
        public decimal Sales { get; set; }

        /// <summary>
        /// Total amount of deposits in this shift.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal Deposits { get; set; }

        /// <summary>
        /// Total amount of withdrawals in this shift.
        /// </summary>
        [MessagePack.Key(16)]
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// Total amount of refunds in this shift.
        /// </summary>
        [MessagePack.Key(17)]
        public decimal Refunds { get; set; }

        /// <summary>
        /// List of shift details by payment method.
        /// </summary>
        [MessagePack.Key(18)]
        public List<ShiftDetailsDTOModel> Details { get; set; } = new List<ShiftDetailsDTOModel>();
    }
}
