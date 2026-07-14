using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification method model.
    /// </summary>
    /// <remarks>
    /// An operator-curated entry in a verification method chain — references an integration instance
    /// together with the capability (delivery mechanism) to use.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class VerificationMethodModel : IWebApiModel
    {
        /// <summary>
        /// Verification method id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Chain context this entry belongs to.
        /// </summary>
        [MessagePack.Key(1)]
        public VerificationContext Context { get; init; }

        /// <summary>
        /// Referenced integration id.
        /// </summary>
        [MessagePack.Key(2)]
        public int IntegrationId { get; init; }

        /// <summary>
        /// Capability guid identifying the delivery mechanism of the referenced integration.
        /// </summary>
        [MessagePack.Key(3)]
        public Guid CapabilityGuid { get; init; }

        /// <summary>
        /// Optional custom display name shown to end users.
        /// When not set the referenced integration name is used.
        /// </summary>
        [MessagePack.Key(4)]
        public string? CustomName { get; init; }

        /// <summary>
        /// Indicates the entry is offered on the initial method selection;
        /// non primary entries serve as fallback.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsPrimary { get; init; }

        /// <summary>
        /// Indicates whether the entry is disabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Display order within the chain.
        /// </summary>
        [MessagePack.Key(7)]
        public int DisplayOrder { get; init; }

        /// <summary>
        /// Name of the referenced integration. Serves as the display name fallback
        /// when <see cref="CustomName"/> is not set.
        /// </summary>
        [MessagePack.Key(8)]
        public string IntegrationName { get; init; } = string.Empty;

        /// <summary>
        /// Localized name of the referenced integration's type, resolved at the request culture.
        /// Not currently displayed — included for future use.
        /// </summary>
        [MessagePack.Key(9)]
        public string? IntegrationTypeName { get; init; }
    }
}
