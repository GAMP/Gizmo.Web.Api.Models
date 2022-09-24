using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class Order : OrderModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(200)]
        public int Id { get; set; }

        /// <summary>
        /// The invoice of the order.
        /// </summary>
        [Key(201)]
        public Invoice Invoice { get; set; }

        #endregion
    }
}