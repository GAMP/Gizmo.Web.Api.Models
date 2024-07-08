using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ProductStockTransactionCreateModel : IWebApiModel
    {
        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        [MessagePack.Key(0)]
        [EnumValueValidation]
        public StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(2)]
        public int BranchId { get; set; }
    }
}
