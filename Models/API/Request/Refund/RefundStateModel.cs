using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refund state model.
    /// </summary>
    /// <remarks>
    /// Provides information on possible refund method and amounts.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class RefundStateModel : IWebApiModel
    {
        /// <summary>
        /// Maximum refund amount.
        /// </summary>
        /// <remarks>
        /// This value will indicate the maximum amount that can be refunded.<br></br>
        /// In most cases it will be the sum of all payments made, in some cases such as with deposits it can be less since <b>part of deposit could have been spent already</b>.
        /// </remarks>
        [MessagePack.Key(0)]
        public decimal MaxRefundAmount { get; init; }

        /// <summary>
        /// Refund methods.
        /// </summary>
        /// <remarks>
        /// When <see cref="RequireOriginalTender"/> will be equal to <see langword="true"/> this collection will contain all the methods that will be used for refund, when <see langword="false"/> this will contain the methods that can be used.
        /// </remarks>
        [MessagePack.Key(1)]
        public IEnumerable<int> RefundMethods { get; set; } = Enumerable.Empty<int>();

        /// <summary>
        /// Indicates original tender.
        /// </summary>
        /// <remarks>
        /// When <see langword="true"/> this will indicate that all the payments identified by <see cref="RefundMethods"/> will be fully reversed (refunded).<br></br>
        /// The value of <see cref="MaxRefundAmount"/> will be equal to sum of the payments.
        /// </remarks>
        [MessagePack.Key(2)]
        public bool RequireOriginalTender { get; init; }

        /// <summary>
        /// Indicates whether a partial refund amount is allowed.
        /// </summary>
        /// <remarks>
        /// When <see langword="true"/> any amount greater than zero and up to <see cref="MaxRefundAmount"/> may be refunded.<br></br>
        /// When <see langword="false"/> the refund must be made for the full <see cref="MaxRefundAmount"/> (for example an electronic original tender that can only be fully reversed, or a multi payment reversal).
        /// </remarks>
        [MessagePack.Key(3)]
        public bool AllowPartial { get; init; }
    }
}
