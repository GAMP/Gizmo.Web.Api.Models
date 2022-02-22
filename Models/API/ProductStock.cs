using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class ProductStock : IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal? OnHand { get; set; }

        #endregion
    }
}