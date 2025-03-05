using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile policies metadata model.
    /// </summary>
    /// <remarks>
    /// Contains set of available security profile polices and groups.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityProfilePolicesMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Policy groups.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<SecurityPolicyGroupMetadataModel> Groups { get; init; } = Enumerable.Empty<SecurityPolicyGroupMetadataModel>();

        /// <summary>
        /// Policies.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<SecurityPolicyMetadataModel> Policies { get; init; } = Enumerable.Empty<SecurityPolicyMetadataModel>();
    }
}
