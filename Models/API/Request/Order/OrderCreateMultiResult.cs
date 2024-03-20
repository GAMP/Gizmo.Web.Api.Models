using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Multiple orders creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderCreateMultiResult : IWebApiModel
    {
        /// <summary>
        /// Order creation results.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<OrderCreateResultModel> Results { get; init; } = [];
    }

}
