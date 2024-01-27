namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Undeleted", "BRANCH_UNDELETED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Branch undeleted event", "BRANCH_UNDELETED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchUndeletedEventMessage : BranchEventMessageBase
    {
        /// <inheritdoc/>
        public BranchUndeletedEventMessage() : base() { }
    }
}
