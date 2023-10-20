namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Shift event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Shift", "SHIFT_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Shift related events", "SHIFT_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(10)]
    public abstract class ShiftEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// Shift id.
        /// </summary>
        [MessagePack.Key(1)]
        public int ShiftId { get; init; }

        /// <summary>
        /// Operator id.
        /// </summary>
        [MessagePack.Key(2)]
        public int OperatorId { get;init; }
    }
}
