using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Describes a verification provider and its capabilities.
    /// </summary>
    [MessagePackObject]
    public sealed class VerificationProviderModel
    {
        /// <summary>
        /// Integration instance public identifier.
        /// </summary>
        [Key(0)]
        public Guid PublicId { get; set; }

        /// <summary>
        /// Human-readable provider name.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Communication channel GUID (e.g. Telegram, Viber).
        /// </summary>
        [Key(2)]
        public Guid ChannelGuid { get; set; }

        /// <summary>
        /// The provider can generate a redirect URL for verification.
        /// </summary>
        [Key(3)]
        public bool CanRedirect { get; set; }

        /// <summary>
        /// The provider can dispatch confirmation codes to known recipients.
        /// </summary>
        [Key(4)]
        public bool CanDispatchCode { get; set; }

        /// <summary>
        /// The provider can return a verified phone number.
        /// </summary>
        [Key(5)]
        public bool CanProvidePhone { get; set; }

        /// <summary>
        /// The provider can return a verified email address.
        /// </summary>
        [Key(6)]
        public bool CanProvideEmail { get; set; }

        /// <summary>
        /// The user has an existing channel record for this provider's communication channel.
        /// Only populated when a user context is available (e.g. recovery, re-verification).
        /// </summary>
        [Key(7)]
        public bool HasChannel { get; set; }

        /// <summary>
        /// The provider is offered on the initial selection; non primary providers serve as fallback.
        /// </summary>
        [Key(8)]
        public bool IsPrimary { get; set; }
    }
}
