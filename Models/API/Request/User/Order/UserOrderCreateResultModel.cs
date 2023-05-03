using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order create result model.
    /// </summary>
    [Serializable, MessagePackObject]
    public class UserOrderCreateResultModel
    {
        #region PROPERTIES

        /// <summary>
        /// The result for the order.
        /// </summary>
        [Key(0)]
        public UserOrderCreateResult Result { get; init; }

        /// <summary>
        /// The Id of the newly created object if was successfull.
        /// </summary>
        [Key(1)]
        public int? Id { get; init; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(2)]
        public IEnumerable<UserOrderLineCreateResultModel> OrderLines { get; set; } = Enumerable.Empty<UserOrderLineCreateResultModel>();

        #endregion
    }
}
