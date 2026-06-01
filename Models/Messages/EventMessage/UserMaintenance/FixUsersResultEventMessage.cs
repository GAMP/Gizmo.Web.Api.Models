using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User fix process result event message.
    /// </summary>
    [MessagePackObject]
    [System.ComponentModel.DataAnnotations.Name("User fix result")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates user fix process result")]
    public sealed class FixUsersResultEventMessage : UserMaintenanceResultEventMessageBase
    {
        /// <summary>
        /// Processed user count.
        /// </summary>
        [Key(5)]
        public int ProcessedUsersCount { get; init; }

        /// <summary>
        /// Count of users whose phone fields need normalization updates.
        /// </summary>
        [Key(6)]
        public int NormalizedPhonesCount { get; init; }

        /// <summary>
        /// Count of users with invalid phone fields.
        /// </summary>
        [Key(7)]
        public int InvalidPhonesCount { get; init; }

        /// <summary>
        /// Count of duplicate normalized mobile phone groups.
        /// </summary>
        [Key(8)]
        public int MergedPhonesCount { get; init; }

        /// <summary>
        /// Count of users that belong to duplicate normalized mobile phone groups.
        /// </summary>
        [Key(9)]
        public int MergeErrorsCount { get; init; }
    }
}
