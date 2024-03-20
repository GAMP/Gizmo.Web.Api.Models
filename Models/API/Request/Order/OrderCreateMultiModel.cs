using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Multi order creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class OrderCreateMultiModel : IWebApiModel
    {
        /// <summary>
        /// Gets creation options.
        /// </summary>
        [MessagePack.Key(0)]
        public OrderCreateParametersModel Parameters { get; init; } = new();

        /// <summary>
        /// Gets orders.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<OrderCreateModel> Orders { get; init; } = [];
    }
}
