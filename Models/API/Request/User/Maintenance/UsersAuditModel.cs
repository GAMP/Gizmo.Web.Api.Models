using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request model for auditing and merging duplicate users.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditModel : IWebApiModel
    {
        /// <summary>
        /// Audit duplicate phone groups.
        /// </summary>
        [Key(0)]
        public bool ByPhone { get; init; } = true;

        /// <summary>
        /// Audit duplicate email groups.
        /// </summary>
        [Key(1)]
        public bool ByEmail { get; init; } = true;

        /// <summary>
        /// Default country used when normalizing phone values that do not already contain a complete international calling code.
        /// </summary>
        [Key(2)]
        public required string DefaultCountryCode { get; init; }
    }

    /// <summary>
    /// Result returned by the synchronous user-audit duplicate search endpoint.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditGetResultModel : IWebApiModel
    {
        /// <summary>
        /// Duplicate audit items found for the requested audit criteria.
        /// </summary>
        [Key(0)]
        public UsersAuditDuplicatedItemModel[] DuplicatedItems { get; init; } = [];

        /// <summary>
        /// Non-fatal audit errors encountered while finding duplicates.
        /// </summary>
        [Key(1)]
        public UsersAuditErrorModel[] Errors { get; init; } = [];
    }

    /// <summary>
    /// Result returned by the asynchronous user-audit endpoint and by audit merge notifications.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditPostResultModel : IWebApiModel
    {
        /// <summary>
        /// Duplicate audit items merged by the audit process.
        /// </summary>
        [Key(0)]
        public UsersAuditMergedItemModel[] MergedItems { get; init; } = [];

        /// <summary>
        /// Non-fatal audit errors encountered while merging duplicates.
        /// </summary>
        [Key(1)]
        public UsersAuditErrorModel[] Errors { get; init; } = [];
    }

    /// <summary>
    /// Duplicate value and users that share it.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditDuplicatedItemModel : IWebApiModel
    {
        /// <summary>
        /// Duplicate value shared by the listed users.
        /// </summary>
        [Key(0)]
        public required string Value { get; init; }

        /// <summary>
        /// Type of duplicated value.
        /// </summary>
        [Key(1)]
        public UsersAuditItemType Type { get; init; }

        /// <summary>
        /// Users that share the duplicate value.
        /// </summary>
        [Key(2)]
        public UsersAuditUserModel[] Users { get; init; } = [];
    }

    /// <summary>
    /// Merged duplicate value and surviving user.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditMergedItemModel : IWebApiModel
    {
        /// <summary>
        /// Duplicate value that was merged.
        /// </summary>
        [Key(0)]
        public required string Value { get; init; }

        /// <summary>
        /// Type of duplicated value that was merged.
        /// </summary>
        [Key(1)]
        public UsersAuditItemType Type { get; init; }

        /// <summary>
        /// Surviving user after the duplicate merge.
        /// </summary>
        [Key(2)]
        public required UsersAuditUserModel User { get; init; }
    }

    /// <summary>
    /// User audit duplicate item type.
    /// </summary>
    public enum UsersAuditItemType
    {
        /// <summary>
        /// Duplicate email address.
        /// </summary>
        Email = 0,

        /// <summary>
        /// Duplicate normalized phone number.
        /// </summary>
        Phone = 1
    }

    /// <summary>
    /// User summary for audit results.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditUserModel : IWebApiModel
    {
        /// <summary>
        /// User identifier. Import validation duplicate results can reuse this model with a negative synthetic id for workbook rows.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// User display name.
        /// </summary>
        [Key(1)]
        public required string Name { get; init; }

        /// <summary>
        /// Most recent known user activity time, if any.
        /// </summary>
        [Key(2)]
        public DateTime? LastActivity { get; init; }
    }

    /// <summary>
    /// User audit error.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersAuditErrorModel : IWebApiModel
    {
        /// <summary>
        /// Human-readable audit error message.
        /// </summary>
        [Key(0)]
        public required string Message { get; init; }
    }
}
