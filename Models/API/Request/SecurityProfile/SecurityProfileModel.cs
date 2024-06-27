using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

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

        #endregion
    }
}
