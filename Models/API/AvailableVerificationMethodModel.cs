using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A verification method offered to the user for a flow.
    /// </summary>
    /// <remarks>
    /// Materialized from an operator-curated verification method chain entry — each item carries
    /// exactly one delivery mechanism; the list order and <see cref="IsPrimary"/> carry the
    /// operator's presentation intent.
    /// </remarks>
    [MessagePackObject]
    public sealed class AvailableVerificationMethodModel : IWebApiModel
    {
        /// <summary>
        /// Display name. Operator custom name when set, otherwise the integration name.
        /// </summary>
        [Key(0)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Communication channel guid — identifies the address kind the mechanism works with
        /// (which destination input to collect in explicit-destination flows) and the UI icon.
        /// </summary>
        [Key(1)]
        public Guid ChannelGuid { get; set; }

        /// <summary>
        /// Verification method entry id — the routing key sent back when starting the method.
        /// </summary>
        [Key(2)]
        public int MethodId { get; set; }

        /// <summary>
        /// Capability guid identifying the delivery mechanism.
        /// </summary>
        [Key(3)]
        public Guid CapabilityGuid { get; set; }

        /// <summary>
        /// The method is offered on the initial selection; non primary methods serve as fallback.
        /// </summary>
        [Key(4)]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// The method is actionable for the current user — a usable channel value exists.
        /// Meaningful in flows that source the destination from the user record (e.g. password recovery).
        /// </summary>
        [Key(5)]
        public bool HasChannel { get; set; }
    }
}
