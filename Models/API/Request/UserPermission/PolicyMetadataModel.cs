using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Policy metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PolicyMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Policy group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string PolicyGroupName { get; init; } = null!;

        /// <summary>
        /// Policy name.
        /// </summary>
        [MessagePack.Key(1)]
        public string PolicyName { get; init; } = null!;

        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(2)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Description.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Description { get; init; } = null!;

        /// <summary>
        /// Claim operation.
        /// </summary>
        [MessagePack.Key(4)]
        public string Operation { get; init; } = null!;

        /// <summary>
        /// Claim resource.
        /// </summary>
        [MessagePack.Key(5)]
        public string Resource { get; init; } = null!;

        /// <summary>
        /// Policy dependencies.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<string> Dependencies { get; init; } = Enumerable.Empty<string>();
    }
}
