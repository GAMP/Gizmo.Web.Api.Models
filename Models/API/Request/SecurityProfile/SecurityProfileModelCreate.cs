using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityProfileModelCreate : IWebApiModel
    {
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
        public IEnumerable<SecurityProfileRestrictionModelCreate> Restrictions { get; init; } = Enumerable.Empty<SecurityProfileRestrictionModelCreate>();

        /// <summary>
        /// Policies.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<SecurityProfilePolicyModelCreate> Policies { get; init; } = Enumerable.Empty<SecurityProfilePolicyModelCreate>();

        /// <summary>
        /// Disable start.
        /// </summary>
        [MessagePack.Key(4)]
        public bool DisableStart { get; init; }

        /// <summary>
        /// Disable desktop switching.
        /// </summary>
        [MessagePack.Key(5)]
        public bool DisableDesktopSwitching { get; init; }

        /// <summary>
        /// Sticky shell.
        /// </summary>
        [MessagePack.Key(6)]
        public bool StickyShell { get; init; }
    }
}
