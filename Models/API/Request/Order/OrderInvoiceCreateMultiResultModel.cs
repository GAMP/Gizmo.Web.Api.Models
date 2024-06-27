using System.Collections.Generic;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Multiple orders creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoiceCreateMultiResultModel : IWebApiModel
    {

        /// <summary>
        /// Order creation results.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<OrderInvoiceCreateResultModel> OrderResults { get; init; } = [];

        /// <summary>
        /// Result.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderMultiCreateResult Result { get; init; }
    }
}
