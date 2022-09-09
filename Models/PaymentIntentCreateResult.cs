using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent creation result.
    /// </summary>
    [Serializable]
    [MessagePack.MessagePackObject()]
    public class PaymentIntentCreateResult : PaymentRequestCreateResult
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment intent guid.
        /// </summary>
        [MessagePack.Key(4)]
        public Guid PaymentIntent
        {
            get; init;
        }

        #endregion
    }
}
