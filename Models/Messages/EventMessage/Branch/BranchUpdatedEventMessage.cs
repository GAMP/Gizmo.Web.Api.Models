namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch updated event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Branch updated", "BRANCH_UPDATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Branch updated event", "BRANCH_UPDATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchUpdatedEventMessage : BranchEventMessageBase
    {
        /// <inheritdoc/>
        public BranchUpdatedEventMessage() : base() { }
    }
}
