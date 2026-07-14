using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification methods bulk reorder model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class VerificationMethodsOrderModel : IWebApiModel
    {
        /// <summary>
        /// Verification method ids in the desired display order.
        /// Each listed entry receives its position index as display order.
        /// </summary>
        [MessagePack.Key(0)]
        public List<int> OrderedIds { get; init; } = new();
    }
}
