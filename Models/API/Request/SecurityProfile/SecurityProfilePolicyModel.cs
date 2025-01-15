using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile policy.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityProfilePolicyModel : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Policy type.
        /// </summary>
        [MessagePack.Key(1)]
        public int Type { get; init; }
    }
}
