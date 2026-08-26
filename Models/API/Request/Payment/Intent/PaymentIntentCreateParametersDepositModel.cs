using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit payment intent creation parameters.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentIntentCreateParametersDepositModel : IPaymentIntentCreateParametersModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets intent user id.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets intent amount.
        /// </summary>
        [Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        /// <remarks>
        /// The method must have payment provider set, otherwise operation will fail.
        /// </remarks>
        [Key(2)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or sets whether the fiscal receipt for the deposit should be electronic only.
        /// </summary>
        /// <remarks>
        /// When set the receipt is registered without printing a paper copy. Defaults to false, so a caller that
        /// does not specify it keeps receiving a printed receipt.
        /// </remarks>
        [Key(3)]
        public bool DisableReceiptPrinting { get; set; }

        #endregion
    }
}
