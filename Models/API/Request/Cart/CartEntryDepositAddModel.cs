namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart entry deposit add model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartEntryDepositAddModel : IWebApiModel
    {
        /// <summary>
        /// Deposit amount.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Amount { get; init; }
    }
}
