using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftExpectedModel : IShiftExpectedModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<ShiftExpectedTransactionModel> Exepected { get; init; } = Enumerable.Empty<ShiftExpectedTransactionModel>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public decimal ExpectedTotal { get; init; }
    }
}
