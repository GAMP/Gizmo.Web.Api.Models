using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// TODO: Make the description
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageRateModel
    {
        /// <summary>
        /// Left available minutes of the usage type. Null if the usage type does not expire.
        /// </summary>
        [Key(0)] public int? AvailableMinutes { get; set; }

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
