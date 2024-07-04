using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class StockTransactionCreateModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Product id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        [MessagePack.Key(1)]
        [EnumValueValidation]
        public StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(3)]
        public int BranchId { get; set; }

        #endregion
    }
}
