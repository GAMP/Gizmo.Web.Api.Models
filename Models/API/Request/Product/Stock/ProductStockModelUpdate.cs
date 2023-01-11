#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductStockModelUpdate : IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

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

        #endregion
    }
}