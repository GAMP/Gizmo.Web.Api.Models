using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance authorization model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AuthorizationModel : IWebApiModel
    {
        /// <summary>
        /// License type.
        /// </summary>
        [MessagePack.Key(0)]
        public LicenseType Type { get; init; }

        /// <summary>
        /// License state.
        /// </summary>
        [MessagePack.Key(1)]
        public LicenseState? State { get; init; }

        /// <summary>
        /// Authorized id type.
        /// </summary>
        [MessagePack.Key(2)]
        public InstanceIdType? AuthorizedIdType { get; init; }

        /// <summary>
        /// Authorized id.
        /// </summary>
        [MessagePack.Key(3)]
        public string? AuthorizedId { get; init; }

        /// <summary>
        /// Gets license count.
        /// </summary>
        [MessagePack.Key(4)]
        public int? Count { get; init; }

        /// <summary>
        /// Gets expiration time.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime? ExpiresAt { get; init; }

        /// <summary>
        /// Gets verification time.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? VerificationTime { get; init; }

        /// <summary>
        /// Gets if the subscription payment is recurring.
        /// </summary>
        [MessagePack.Key(7)]
        public bool? IsRecurring { get; init; }

        /// <summary>
        /// Gets warnings.
        /// </summary>
        /// <remarks>
        /// The enum is flag and need special handling for localization.
        /// </remarks>
        [MessagePack.Key(8)]
        public AuthorizationWarnings? Warnings { get; init; }

        /// <summary>
        /// Gets if authorization where done locally.
        /// </summary>
        [MessagePack.Key(9)]
        public bool? IsLocal { get; init; }
    }
}
