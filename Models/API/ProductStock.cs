using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ProductStock : IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        [DataMember]
        public decimal? OnHand { get; set; }

        #endregion
    }
}