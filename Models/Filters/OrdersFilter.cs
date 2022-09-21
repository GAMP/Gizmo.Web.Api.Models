using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for orders.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class OrdersFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return orders where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return orders where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return orders with the specified order status.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(202)]
        public OrderStatus? Status { get; set; }
    }
}
