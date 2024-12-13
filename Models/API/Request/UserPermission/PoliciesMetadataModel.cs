using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Policies metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PoliciesMetadataModel : IWebApiModel 
    {
        /// <summary>
        /// Policy groups.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PolicyGroupMetadataModel> Groups { get; init; }  = Enumerable.Empty<PolicyGroupMetadataModel>();

        /// <summary>
        /// Policies.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<PolicyMetadataModel> Policies { get; init; } = Enumerable.Empty<PolicyMetadataModel>();
    }
}
