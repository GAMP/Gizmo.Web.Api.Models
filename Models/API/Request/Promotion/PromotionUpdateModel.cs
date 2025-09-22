using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion update model.
    /// </summary>
    public sealed class PromotionUpdateModel : IWebApiModel
    {
        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(0)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Period.
        /// </summary>
        [MessagePack.Key(1)]
        public PeriodModel Period { get; set; } = new PeriodModel();
        
        /// <summary>
        /// Branches.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<BranchReferenceModelUpdate> Branches { get; set; } = Enumerable.Empty<BranchReferenceModelUpdate>();
    }
}
