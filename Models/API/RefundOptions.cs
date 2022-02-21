using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refund options.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class RefundOptions
    {
        /// <summary>
        /// The Id of the payment method to use for the refund.
        /// </summary>
        [DataMember]
        public int? RefundMethodId { get; set; }
    }
}
