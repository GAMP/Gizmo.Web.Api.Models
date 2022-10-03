using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent state changed.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Created", "PAYMENT_INTENT_STATE_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent state change", "PAYMENT_INTENT_STATE_CHANGED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentStateChangedEventMessage : PaymentIntentEventMessageBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets intent previous state.
        /// </summary>
        [Key(3)]
        public PaymentIntentState PreviousState
        {
            get; init;
        }

        /// <summary>
        /// Gets intent new state.
        /// </summary>
        [Key(4)]
        public PaymentIntentState CurrentState
        {
            get; init;
        } 

        #endregion
    }
}
