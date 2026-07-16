using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request model for validating or starting a user import from an uploaded workbook.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersImportOptionsModel : IWebApiModel
    {
        /// <summary>
        /// Default country used when normalizing phone values that do not already contain a complete international calling code.
        /// </summary>
        [Key(0)]
        public required string DefaultCountryCode { get; init; }
    }

    /// <summary>
    /// Result returned by the synchronous user-import validation endpoint.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersImportValidationResultModel : IWebApiModel
    {
        /// <summary>
        /// Duplicate audit items found while validating the workbook against itself and existing users.
        /// Workbook rows are represented as negative user ids where -Id equals the workbook row number.
        /// </summary>
        [Key(0)]
        public UsersAuditDuplicateItemModel[] DuplicatedItems { get; init; } = [];

        /// <summary>
        /// Workbook users that do not exist in the database and would be created by import execution.
        /// </summary>
        [Key(1)]
        public UsersImportRowModel[] UniqueUsers { get; init; } = [];

        /// <summary>
        /// Row-level validation errors.
        /// </summary>
        [Key(2)]
        public UsersImportErrorModel[] Errors { get; init; } = [];
        /// <summary>
        /// Temporary error-workbook report available when validation found errors.
        /// </summary>
        [Key(3)]
        public UsersImportErrorReportModel? ErrorReport { get; init; }
    }

    /// <summary>
    /// Temporary error-workbook report created by user-import validation or execution.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersImportErrorReportModel : IWebApiModel
    {
        /// <summary>
        /// Opaque report identifier used to download the error workbook.
        /// </summary>
        [Key(0)]
        public Guid ReportId { get; init; }

        /// <summary>
        /// Download file name.
        /// </summary>
        [Key(1)]
        public required string FileName { get; init; }

        /// <summary>
        /// UTC expiration time for the temporary report.
        /// </summary>
        [Key(2)]
        public DateTimeOffset ExpiresAtUtc { get; init; }
    }

    /// <summary>
    /// Result returned by the asynchronous user-import process notification.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersImportExecutionResultModel : IWebApiModel
    {
        /// <summary>
        /// Users created by the import process.
        /// </summary>
        [Key(0)]
        public UsersImportRowModel[] CreatedUsers { get; init; } = [];

        /// <summary>
        /// Existing users merged by the import process.
        /// </summary>
        [Key(1)]
        public UsersImportRowModel[] MergedUsers { get; init; } = [];

        /// <summary>
        /// Row-level import errors.
        /// </summary>
        [Key(2)]
        public UsersImportErrorModel[] Errors { get; init; } = [];

        /// <summary>
        /// Temporary error-workbook report available when the import completed with errors and report storage succeeded.
        /// </summary>
        [Key(3)]
        public UsersImportErrorReportModel? ErrorReport { get; init; }
    }

    /// <summary>
    /// User returned by import validation or execution results.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersImportRowModel : IWebApiModel
    {
        /// <summary>
        /// User identifier, when the user already exists or was created. Validation-only unique users have no id yet.
        /// </summary>
        [Key(0)]
        public int? Id { get; init; }

        /// <summary>
        /// Workbook row number.
        /// </summary>
        [Key(1)]
        public int RowNumber { get; init; }

        /// <summary>
        /// User login.
        /// </summary>
        [Key(2)]
        public string? Username { get; init; }

        /// <summary>
        /// User email address.
        /// </summary>
        [Key(3)]
        public string? Email { get; init; }

        /// <summary>
        /// Normalized mobile phone number.
        /// </summary>
        [Key(4)]
        public string? MobilePhone { get; init; }
    }

    /// <summary>
    /// Row-level user import error.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersImportErrorModel : IWebApiModel
    {
        /// <summary>
        /// Excel row number where the error was found.
        /// </summary>
        [Key(0)]
        public int RowNumber { get; init; }

        /// <summary>
        /// Field name associated with the error, when applicable.
        /// </summary>
        [Key(1)]
        public string? Field { get; init; }

        /// <summary>
        /// Error message.
        /// </summary>
        [Key(2)]
        public required string Message { get; init; }
    }
}
