using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Rate usage model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageRateModel
    {
        /// <summary>
        /// Remaining minutes.
        /// </summary>
        /// <remarks>
        /// Total remaining minutes in usage type.<br></br>
        /// This value is always the same with <see cref="UserUsageTimeLevelModel.UsableMinutes"/>.<br></br>
        /// <b>This value is not currently used.</b>
        /// </remarks>
        [Key(0)] public int? RemainingMinutes { get; set; }

        /// <summary>
        /// Id of the BillRate that was used to purchase the usage type.
        /// </summary>
        [Key(1)] public int BillRateId { get; init; }

        /// <summary>
        /// Flag indicating if the usage type is in credit.
        /// </summary>
        [Key(2)] public bool InCredit { get; init; }

        /// <summary>
        /// Hourly rate of the usage type.
        /// </summary>
        [Key(3)] public decimal HourlyRate { get; init; }
    }
}
