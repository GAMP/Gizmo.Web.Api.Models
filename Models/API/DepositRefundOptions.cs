using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit refund options.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DepositRefundOptions : RefundOptions
    {
        #region PROPERTIES
        
        /// <summary>
        /// The amount to refund, if null the total amount will be refunded.
        /// </summary>
        [Key(100)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Whether to override the receipt.
        /// </summary>
        [Key(101)]
        public bool ReceiptOverride { get; set; } 

        #endregion
    }
}
