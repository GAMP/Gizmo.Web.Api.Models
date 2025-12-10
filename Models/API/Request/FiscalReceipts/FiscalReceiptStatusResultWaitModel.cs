using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization task status wait result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FiscalReceiptStatusResultWaitModel : IWebApiModel
    {
        /// <summary>
        /// Result status.
        /// </summary>
        [MessagePack.Key(0)]
        public Gizmo.FiscalReceiptPrintStatus Status { get; init; }

        /// <summary>
        /// Created fiscal receipt's id's.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<int> Receipts { get; set; } = Enumerable.Empty<int>();

        /// <summary>
        /// Optional receipt printing error messages.
        /// </summary>
        /// <remarks>
        /// This value will only be set if <see cref="Status"/> is equal to <see cref="Gizmo.FiscalReceiptPrintStatus.Failed"/>.<br></br>
        /// <b>If the receipt is already in failed state when wait is initiated this value will be equal to null.</b>
        /// </remarks>
        [MessagePack.Key(2)]
        public IEnumerable<string> Errors { get; init; } = Enumerable.Empty<string>();
    }
}
