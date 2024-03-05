namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout removed", "HOST_LAYOUT_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout removed event", "HOST_LAYOUT_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutRemovedEventMessage : HostLayoutEventMessageBase
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
