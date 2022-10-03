#nullable enable

using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent created message.
    /// </summary>
    [MessagePackObject()]
    public sealed class PaymentIntentCreatedEventMessage : PaymentIntentEventMessageBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment provider.
        /// </summary>
        [Key(3)]
        public Guid Provider
        {
            get;init;
        }

        /// <summary>
        /// Gets payment intent type.
        /// </summary>
        [Key(4)]
        public PaymentIntentType PaymentIntentType { get; init; }
        
        /// <summary>
        /// Gets intent amount.
        /// </summary>
        [Key(5)]
        public decimal Amount
        {
            get; init;
        } 

        #endregion
    }
}
