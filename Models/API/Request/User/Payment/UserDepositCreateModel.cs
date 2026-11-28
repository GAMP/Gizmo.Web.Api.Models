using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request to top up the balance of the current user with an online payment.
    /// </summary>
    [MessagePackObject]
    public sealed class UserDepositCreateModel : IWebApiModel
    {
        /// <summary>
        /// Top up amount.
        /// </summary>
        [Key(0)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Online payment method id.
        /// </summary>
        [Key(1)]
        public int PaymentMethodId { get; set; }
    }
}
