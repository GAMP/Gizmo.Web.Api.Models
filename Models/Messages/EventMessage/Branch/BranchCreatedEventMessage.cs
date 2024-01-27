namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Branch created", "BRANCH_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Branch created event", "BRANCH_CREATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchCreatedEventMessage : BranchEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BranchCreatedEventMessage() : base() { }
    }
}
