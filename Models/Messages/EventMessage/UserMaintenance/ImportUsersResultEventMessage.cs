using Gizmo.Web.Api.Models;
using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User import process result event message.
    /// </summary>
    [MessagePackObject]
    [System.ComponentModel.DataAnnotations.Name("User import result")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates import-users process result")]
    public sealed class ImportUsersResultEventMessage : UserMaintenanceResultEventMessageBase
    {
        /// <summary>
        /// Import result payload.
        /// </summary>
        [Key(5)]
        public required UsersImportExecutionResultModel Result { get; init; }
    }
}
