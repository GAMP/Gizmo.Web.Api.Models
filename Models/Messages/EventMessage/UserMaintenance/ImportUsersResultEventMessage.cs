using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User import-users process result event message.
    /// </summary>
    [MessagePackObject]
    [System.ComponentModel.DataAnnotations.Name("ImportUsersResult")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates import-users process initialization result")]
    public sealed class ImportUsersResultEventMessage : UserMaintenanceResultEventMessageBase
    {
        /// <summary>
        /// Imported file name.
        /// </summary>
        [Key(5)]
        public string FileName { get; init; } = string.Empty;

        /// <summary>
        /// Processed user count.
        /// </summary>
        [Key(6)]
        public int ProcessedUsersCount { get; init; }

        /// <summary>
        /// Count of users whose phone fields need normalization updates.
        /// </summary>
        [Key(7)]
        public int NormalizedPhonesCount { get; init; }

        /// <summary>
        /// Count of duplicate normalized mobile phone groups.
        /// </summary>
        [Key(8)]
        public int MergedPhonesCount { get; init; }

        /// <summary>
        /// Row-level import errors found during parsing, field validation, or matching prechecks.
        /// </summary>
        [Key(9)]
        public ImportUsersErrorModel[] Errors { get; init; } = [];
    }
}
