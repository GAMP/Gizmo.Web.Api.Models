#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [MessagePackObject]
    public sealed class DepositTransactionModelCreate : IDepositTransactionApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Whether to override the receipt.
        /// </summary>
        [MessagePack.Key(0)]
        public bool ReceiptOverride { get; set; }

        /// <summary>
        /// The Id of the user this deposit transaction is associated with.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; set; }

        /// <summary>
        /// The type of the deposit transaction.
        /// </summary>
        [MessagePack.Key(2)]
        [EnumValueValidation]
        public DepositTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the deposit transaction.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The Id of the payment method of this deposit transaction.
        /// </summary>
        [MessagePack.Key(4)]
        public int? PaymentMethodId { get; set; }

        #endregion
    }
}