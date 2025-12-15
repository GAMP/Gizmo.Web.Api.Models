using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FiscalizationCreateModel : IWebApiModel
    {
        /// <summary>
        /// Fiscalization tasks.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<FiscalizationTaskModel> Tasks { get; set; } = Enumerable.Empty<FiscalizationTaskModel>();

        /// <summary>
        /// Disable receipt printing.
        /// </summary>
        [MessagePack.Key(1)]
        public bool DisableReceiptPrinting { get; init; }
    }
}
