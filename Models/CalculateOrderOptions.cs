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
    public class CalculateOrderOptions : CalculateOrderOptionsModelBase
    {
        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [DataMember]
        public int? PreferredPaymentMethodId { get; set; }
    }
}