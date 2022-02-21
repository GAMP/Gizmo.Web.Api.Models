using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class Order : OrderModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public int Id { get; set; }

        /// <summary>
        /// The invoice of the order.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public Invoice Invoice { get; set; }

        #endregion
    }
}