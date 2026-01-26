using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit withdraw payments model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DepositWithdrawPaymentsStateModel : IWebApiModel
    {
        /// <summary>
        /// Allowed payment methods.
        /// </summary>
        [MessagePack.Key(0)]
        public required IEnumerable<int> AllowedPaymentMethods { get; init; }

        /// <summary>
        /// Maximum withdraw amount.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal MaximumAmount { get; init; }
    }
}
