using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Payment
{
    /// <summary>
    /// Payment intent creation result.
    /// </summary>
    [MessagePackObject()]
    public class PaymentIntentCreateResult : PaymentRequestCreateResult
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment intent guid.
        /// </summary>
        [Key(4)]
        public Guid PaymentIntent
        {
            get; init;
        }

        #endregion
    }
}
