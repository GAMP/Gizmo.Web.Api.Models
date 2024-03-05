namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout created", "HOST_LAYOUT_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout created event", "HOST_LAYOUT_CREATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutCreatedEventMessage : HostLayoutEventMessageBase
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostId { get; set; }

        /// <summary>
        /// Host layout id.
        /// </summary>
        [MessagePack.Key(3)]
        public int HostLayoutId { get; set; }
    }
}
