using Gizmo.Web.Api.Models;
using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User audit process result event message.
    /// </summary>
    [MessagePackObject]
    [System.ComponentModel.DataAnnotations.Name("User audit result")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates user audit merge process result")]
    public sealed class AuditUsersResultEventMessage : UserMaintenanceResultEventMessageBase
    {
        /// <summary>
        /// Audit merge result.
        /// </summary>
        [Key(5)]
        public required UsersAuditPostResultModel Result { get; init; }
    }
}
