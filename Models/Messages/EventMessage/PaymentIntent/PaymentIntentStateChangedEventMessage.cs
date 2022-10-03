using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent state changed.
    /// </summary>
    [MessagePackObject()]
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
