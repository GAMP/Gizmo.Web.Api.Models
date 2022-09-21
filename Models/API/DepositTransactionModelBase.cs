using MessagePack;
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
    [MessagePackObject]
    public class DepositTransactionModelBase
    {
        /// <summary>
        /// The Id of the user this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// The type of the deposit transaction.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public DepositTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the deposit transaction.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The Id of the payment method of this deposit transaction.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public int? PaymentMethodId { get; set; }
    }
}