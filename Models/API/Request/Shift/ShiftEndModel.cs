using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IShiftEndModel"/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftEndModel : IWebApiModel, IShiftEndModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<ShiftCountModel> Counts { get;set; } = Enumerable.Empty<ShiftCountModel>();
    }
}
