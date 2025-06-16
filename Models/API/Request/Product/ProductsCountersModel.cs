using MessagePack;

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Products counters.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductsCountersModel
    {
        #region PROPERTIES

        /// <summary>
        /// Counters per product group.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<ProductGroupCountersModel> CountersPerGroup { get; set; } = Enumerable.Empty<ProductGroupCountersModel>();

        /// <summary>
        /// Total products.
        /// </summary>
        [MessagePack.Key(1)]
        public int TotalProducts { get; set; }

        /// <summary>
        /// Deleted products.
        /// </summary>
        [MessagePack.Key(2)]
        public int DeletedProducts { get; set; }

        #endregion
    }
}
