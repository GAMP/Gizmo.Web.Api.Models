using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent creation result.
    /// </summary>
    [ProtoBuf.ProtoContract()]
    [MessagePack.MessagePackObject()]
    public class PaymentIntentCreateResult : PaymentRequestCreateResult
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment intent guid.
        /// </summary>
        [MessagePack.Key(4)]
        [ProtoBuf.ProtoMember(1)]
        public Guid PaymentIntent
        {
            get; init;
        }

        #endregion
    }
}
