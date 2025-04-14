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
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Disabled drives.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisabledDrives { get; init; }

        /// <summary>
        /// Restrictions.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<SecurityProfileRestrictionModel> Restrictions { get; init; } = Enumerable.Empty<SecurityProfileRestrictionModel>();

        /// <summary>
        /// Policies.
        /// </summary>
        [MessagePack.Key(4)]
        public IEnumerable<SecurityProfilePolicyModel> Policies { get; init; } = Enumerable.Empty<SecurityProfilePolicyModel>();

        /// <summary>
        /// Disable start.
        /// </summary>
        [MessagePack.Key(5)]
        public bool DisableStart { get; init; }

        /// <summary>
        /// Disable desktop switching.
        /// </summary>
        [MessagePack.Key(6)]
        public bool DisableDesktopSwitching { get; init; }

        /// <summary>
        /// Sticky shell.
        /// </summary>
        [MessagePack.Key(7)]
        public bool StickyShell { get; init; }
    }
}
