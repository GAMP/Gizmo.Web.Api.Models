using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class ProductStockModelUpdate : IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The type of the stock transaction.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public StockTransactionType Type { get; set; }

        /// <summary>
        /// The amount of the stock transaction.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        #endregion
    }
}