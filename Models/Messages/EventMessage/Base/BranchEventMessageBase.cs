namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Branch request event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Branch", "BRANCH_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Branch related events", "BRANCH_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(11)]
    public abstract class BranchEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public BranchEventMessageBase() :base()
        { }

        /// <summary>
        /// Gets branch id.
        /// </summary>
        [MessagePack.Key(0)]
        public int BranchId { get; init; }
    }
}
