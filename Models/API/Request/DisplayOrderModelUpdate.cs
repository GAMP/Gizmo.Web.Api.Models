using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Display order.
    /// </summary>
    [MessagePackObject]
    public sealed class DisplayOrderModelUpdate
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<DisplayOrderEntryModel> Entries { get; set; } = Enumerable.Empty<DisplayOrderEntryModel>();

        #endregion
    }
}
