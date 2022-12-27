using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Stock
{
    /// <summary>
    /// Stock transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class StockTransactionModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The date that the stock transaction was created.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the product this stock transaction is associated with.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount of the stock after the stock transaction.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal OnHand { get; set; }

        /// <summary>
        /// The Id of the operator who performed the stock transaction.
        /// </summary>
        [MessagePack.Key(5)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift that the stock transaction belongs.
        /// </summary>
        [MessagePack.Key(6)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register on which the stock transaction was performed.
        /// </summary>
        [MessagePack.Key(7)]
        public int? RegisterId { get; set; }

        #endregion
    }
}
