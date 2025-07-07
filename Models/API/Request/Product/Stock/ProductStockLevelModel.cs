using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock level model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductStockLevelModel : IWebApiModel
    {
        /// <summary>
        /// Product id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <summary>
        /// Stock levels.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<StockLevelModel> Levels { get; set; } = Enumerable.Empty<StockLevelModel>();
    }
}
