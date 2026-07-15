using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Describes a single integration capability.
    /// </summary>
    /// <remarks>
    /// Name and description are resolved from the capability interface's localized attributes at the
    /// request culture. Interaction shape is deliberately not exposed — clients learn the required
    /// user action from the polymorphic verification start result.
    /// </remarks>
    [MessagePackObject]
    public sealed class IntegrationCapabilityModel : IWebApiModel
    {
        /// <summary>
        /// The stable capability guid.
        /// </summary>
        [Key(0)]
        public Guid CapabilityGuid { get; set; }

        /// <summary>
        /// Localized capability display name.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Localized capability description.
        /// </summary>
        [Key(2)]
        public string? Description { get; set; }
    }
}
