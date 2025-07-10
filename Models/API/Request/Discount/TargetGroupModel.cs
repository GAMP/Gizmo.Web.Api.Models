using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Target group model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TargetGroupModel
    {
        /// <summary>
        /// Target requirements.
        /// </summary>
        [MessagePack.Key(0)]
        public TargetRequirement Requirement { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Include all targets in group.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IncludeAll { get; set; }

        /// <summary>
        /// Targets.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<int> Targets { get; set; } = Enumerable.Empty<int>();
    }
}
