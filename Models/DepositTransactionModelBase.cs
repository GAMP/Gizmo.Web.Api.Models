using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    public class DepositTransactionModelBase
    {
        /// <summary>
        /// The Id of the user this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// The type of the deposit transaction.
        /// </summary>
        [DataMember]
        [EnumValue]
        public DepositTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the deposit transaction.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// The Id of the payment method of this deposit transaction.
        /// </summary>
        [DataMember]
        public int? PaymentMethodId { get; set; }
    }
}