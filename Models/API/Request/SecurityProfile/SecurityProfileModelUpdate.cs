using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class SecurityProfileModelUpdate : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Disabled drives.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisabledDrives { get; init; }

        /// <summary>
        /// Restrictions.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<SecurityProfileRestrictionModel> Restrictions { get; init; } = Enumerable.Empty<SecurityProfileRestrictionModel>();

        /// <summary>
        /// Policies.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<SecurityProfilePolicyModel> Policies { get; init; } = Enumerable.Empty<SecurityProfilePolicyModel>();
    }
}
