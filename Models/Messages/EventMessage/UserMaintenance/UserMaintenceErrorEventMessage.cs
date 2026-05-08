using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User maintenance error process result event message.
    /// </summary>
    [MessagePackObject]
    [System.ComponentModel.DataAnnotations.Name("User maintenance error")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates user maintenance process error result")]
    public sealed class UserMaintenceErrorEventMessage : UserMaintenanceResultEventMessageBase
    {
        /// <summary>
        /// Localized process error message.
        /// </summary>
        [Key(5)]
        public string Message { get; init; } = string.Empty;
    }
}
