using Gizmo.Client.Options;

using MessagePack;

using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mobile app options model.
    /// </summary>
    /// <remarks>
    /// This model is used by the mobile app before user login.
    /// </remarks>
    [MessagePackObject]
    public sealed class MobileOptionsModel
    {
        /// <summary>
        /// Whether mobile app user registration is enabled.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public bool IsRegistrationEnabled { get; init; }

        /// <summary>
        /// Whether mobile app user password recovery is enabled.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public bool IsPasswordRecoveryEnabled { get; init; }

        /// <summary>
        /// Logo image guid; null when no logo is configured.
        /// </summary>
        [Key(2)]
        [JsonPropertyOrder(2)]
        public Guid? LogoImageGuid { get; init; }

        /// <summary>
        /// Preferred language.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public string PreferredLanguage { get; init; } = null!;

        /// <summary>
        /// Country code.
        /// </summary>
        [Key(4)]
        [JsonPropertyOrder(4)]
        public string? CountryCode { get; init; }

        /// <summary>
        /// Password validation options.
        /// </summary>
        [Key(5)]
        [JsonPropertyOrder(5)]
        public PasswordValidationOptions PasswordValidation { get; init; } = null!;
    }
}
