using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for orders.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OrdersFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return orders where the date greater than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return orders where the date less than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return orders with the specified order status.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(202)]
        public OrderStatus? Status { get; set; } 

        #endregion
    }
}
