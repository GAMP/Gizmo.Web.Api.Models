using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Assistance request event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Assistance request", "ASSISTANCE_REQUEST_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Assistance request related events", "ASSISTANCE_REQUEST_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(9)]
    public abstract class AssistanceRequestEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// Gets user id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; init; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId { get; init; }

        /// <summary>
        /// Gets last modification time.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime Time { get; init; }
    }
}
