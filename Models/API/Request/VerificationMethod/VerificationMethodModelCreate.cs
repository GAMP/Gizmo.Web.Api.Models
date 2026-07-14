using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification method create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class VerificationMethodModelCreate : IWebApiModel
    {
        /// <summary>
        /// Chain context the entry belongs to.
        /// </summary>
        [MessagePack.Key(0)]
        public VerificationContext Context { get; init; }

        /// <summary>
        /// Referenced integration id.
        /// </summary>
        [MessagePack.Key(1)]
        public int IntegrationId { get; init; }

        /// <summary>
        /// Capability guid identifying the delivery mechanism.
        /// Must be one of the capabilities of the referenced integration's type.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid CapabilityGuid { get; init; }

        /// <summary>
        /// Optional custom display name shown to end users.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(3)]
        public string? CustomName { get; init; }

        /// <summary>
        /// Indicates the entry is offered on the initial method selection.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsPrimary { get; init; }

        /// <summary>
        /// Indicates whether the entry is disabled.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Display order within the chain, or <see langword="null"/> to append at the end.
        /// </summary>
        [MessagePack.Key(6)]
        public int? DisplayOrder { get; init; }
    }
}
