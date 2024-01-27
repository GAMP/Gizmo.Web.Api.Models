namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch operator added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Operator added", "BRANCH_OPERATOR_ADDED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Operator added event", "BRANCH_OPERATOR_ADDED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchOperatorAddedEventMessage : BranchEventMessageBase
    {
        /// <summary>
        /// Gets operator id.
        /// </summary>
        [MessagePack.Key(2)]
        public int OperatorId { get; init; }
    }
}
