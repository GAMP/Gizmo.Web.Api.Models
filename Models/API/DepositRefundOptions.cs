using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit refund options.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class DepositRefundOptions : RefundOptions
    {
        /// <summary>
        /// The amount to refund, if null the total amount will be refunded.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public decimal? Amount { get; set; }
    }
}
