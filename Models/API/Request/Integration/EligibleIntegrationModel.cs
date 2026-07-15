using System;
using System.Collections.Generic;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An integration offerable in a verification context's method chain, together with the
    /// mechanisms it can still be added with.
    /// </summary>
    /// <remarks>
    /// A composition-time answer, not a static type description — pairs already present in the
    /// context's chain are excluded (the unique key makes them un-addable), so the capability list
    /// shrinks as the chain is composed and the integration disappears once fully consumed.
    /// </remarks>
    [MessagePackObject]
    public sealed class EligibleIntegrationModel : IWebApiModel
    {
        /// <summary>
        /// The integration id — the value a verification method create references.
        /// </summary>
        [Key(0)]
        public int IntegrationId { get; set; }

        /// <summary>
        /// The integration instance name.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Localized integration type display name.
        /// </summary>
        [Key(2)]
        public string TypeName { get; set; } = null!;

        /// <summary>
        /// The integration type's communication channel.
        /// </summary>
        [Key(3)]
        public Guid ChannelGuid { get; set; }

        /// <summary>
        /// The mechanisms eligible for the context and not yet configured in its chain — never empty.
        /// </summary>
        [Key(4)]
        public List<IntegrationCapabilityModel> Capabilities { get; set; } = new();
    }
}
