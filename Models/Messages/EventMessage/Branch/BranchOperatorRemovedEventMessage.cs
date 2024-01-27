namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch operator removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Operator removed", "BRANCH_OPERATOR_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Operator removed event", "BRANCH_OPERATOR_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchOperatorRemovedEventMessage : BranchEventMessageBase
    {
        /// <inheritdoc/>
        public BranchOperatorRemovedEventMessage() : base() { }

        /// <summary>
        /// Gets operator id.
        /// </summary>
        [MessagePack.Key(2)]
        public int OperatorId { get; init; }
    }
}
