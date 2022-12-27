using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Deposit
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DepositTransactionModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user this deposit transaction is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// The type of the deposit transaction.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public DepositTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the deposit transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The Id of the payment method of this deposit transaction.
        /// </summary>
        [MessagePack.Key(3)]
        public int? PaymentMethodId { get; set; }

        #endregion
    }
}