using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ProductStockModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        [DataMember]
        public StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        #endregion
    }
}