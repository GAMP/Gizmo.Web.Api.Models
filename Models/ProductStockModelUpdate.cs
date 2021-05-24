using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ProductStockModelUpdate : IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        [DataMember]
        [EnumValue]
        public StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        #endregion
    }
}