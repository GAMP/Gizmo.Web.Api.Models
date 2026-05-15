using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User import-users process result event message.
    /// </summary>
    [MessagePackObject]
    [System.ComponentModel.DataAnnotations.Name("User import users result")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates user import-users process initialization result")]
    public sealed class UserImportUsersResultEventMessage : UserMaintenanceResultEventMessageBase
    {
        /// <summary>
        /// Imported file name.
        /// </summary>
        [Key(5)]
        public string FileName { get; init; } = string.Empty;

        /// <summary>
        /// Parsed worksheet name.
        /// </summary>
        [Key(6)]
        public string WorksheetName { get; init; } = string.Empty;

        /// <summary>
        /// Header row number.
        /// </summary>
        [Key(7)]
        public int HeaderRow { get; init; }

        /// <summary>
        /// Header names parsed from the workbook.
        /// </summary>
        [Key(8)]
        public string[] Headers { get; init; } = [];

        /// <summary>
        /// Last used row in the worksheet.
        /// </summary>
        [Key(9)]
        public int LastRow { get; init; }

        /// <summary>
        /// Last used column in the worksheet.
        /// </summary>
        [Key(10)]
        public int LastColumn { get; init; }

        /// <summary>
        /// Number of data rows after the header row.
        /// </summary>
        [Key(11)]
        public int DataRowCount { get; init; }
    }
}
