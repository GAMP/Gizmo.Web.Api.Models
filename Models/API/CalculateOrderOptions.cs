using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class CalculateOrderOptions : CalculateOrderOptionsModelBase
    {
        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int? PreferredPaymentMethodId { get; set; }
    }
}