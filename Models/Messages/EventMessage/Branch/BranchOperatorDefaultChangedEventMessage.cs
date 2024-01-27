namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch operator default changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Operators default branch change", "BRANCH_OPERATOR_DEFAULT_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Operators default branch change event", "BRANCH_OPERATOR_DEFAULT_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BranchOperatorDefaultChangedEventMessage : BranchEventMessageBase
    {
        /// <inheritdoc/>
        public BranchOperatorDefaultChangedEventMessage():base() { }

        /// <summary>
        /// Gets operator id.
        /// </summary>
        [MessagePack.Key(2)]
        public int OperatorId { get; init; }
    }
}
