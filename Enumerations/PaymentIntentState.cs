using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent state.
    /// </summary>
    public enum PaymentIntentState
    {
        /// <summary>
        /// The intent is pending.
        /// </summary>
        [Name("Pending", "PAYMENT_INTENT_STATE_PENDING")]
        Pending = 0,

        /// <summary>
        /// The intent is completed.
        /// </summary>
        [Name("Completed", "PAYMENT_INTENT_STATE_COMPLETED")]
        Completed = 1,

        /// <summary>
        /// The intent is failed.
        /// </summary>
        [Name("Failed", "PAYMENT_INTENT_STATE_FAILED")]
        Failed = 2,

        /// <summary>
        /// The intent is expired.
        /// </summary>
        [Name("Expired", "PAYMENT_INTENT_STATE_EXPIRED")]
        Expired = 4,

        /// <summary>
        /// The intent is cancelled.
        /// </summary>
        [Name("Cancelled", "PAYMENT_INTENT_STATE_CANCELLED")]
        Cancelled = 5,

        /// <summary>
        /// The payment captured.
        /// </summary>
        [Name("Captured", "PAYMENT_INTENT_STATE_CAPTURED")]
        Captured = 6,

        /// <summary>
        /// Payment declined.
        /// </summary>
        [Name("Declined", "PAYMENT_INTENT_STATE_DECLINED")]
        Declined = 7,
    }
}
