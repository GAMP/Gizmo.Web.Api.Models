namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host computer event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host computer", "HOST_COMPUTER_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host computer related events", "HOST_COMPUTER_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(17)]
    public abstract class HostComputerEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public HostComputerEventMessageBase() : base()
        { }

        /// <summary>
        /// Gets host computer id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId
        {
            get;init;
        }
    }
}
