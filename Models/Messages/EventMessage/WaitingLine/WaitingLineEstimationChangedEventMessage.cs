namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line user added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Estimation changed", "WAITING_LINE_ESTIMATION_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Estimation changed event", "WAITING_LINE_ESTIMATION_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineEstimationChangedEventMessage : WaitingLineEventMessageBase
    {
        /// <summary>
        /// Waiting line entry id.
        /// </summary>
        [MessagePack.Key(1)]
        public int EntryId
        {
            get; init;
        }
    }
}
