using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent event message base
    /// </summary>
    public abstract class PaymentIntentEventMessageBase : APIEventMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment intent.
        /// </summary>
        [Key(1)]
        public Guid Intent
        {
            get; init;
        }

        /// <summary>
        /// Gets payment intent user id.
        /// </summary>
        [Key(2)]
        public int UserId
        {
            get; init;
        }

        #endregion
    }
}
