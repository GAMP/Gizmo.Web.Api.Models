using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductStock : IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        [Key(1)]
        public decimal? OnHand { get; set; }

        #endregion
    }
}