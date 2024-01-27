namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Deleted", "BRANCH_DELETED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Branch deleted event", "BRANCH_DELETED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchDeletedEventMessage : BranchEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BranchDeletedEventMessage() : base() { }
    }
}
