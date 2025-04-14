using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class SecurityProfileModel : ISecurityProfileModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the security profile.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The disabled drives of the security profile.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisabledDrives { get; set; }

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

        #endregion
    }
}
