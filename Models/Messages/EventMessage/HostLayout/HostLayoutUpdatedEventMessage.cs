namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout updated event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout updated", "HOST_LAYOUT_UPDATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout updated event", "HOST_LAYOUT_UPDATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutUpdatedEventMessage : HostLayoutEventMessageBase
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
