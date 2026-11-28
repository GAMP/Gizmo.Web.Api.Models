using Gizmo.Client.Options;
using Gizmo.UI;

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

        /// <summary>
        /// Currency options.
        /// </summary>
        /// <remarks>
        /// Filled from the server CURRENCY options, same as the client options currency.
        /// </remarks>
        [Key(6)]
        [JsonPropertyOrder(6)]
        public CurrencyOptions Currency { get; init; } = null!;

        /// <summary>
        /// Active map provider.
        /// </summary>
        /// <remarks>
        /// <see cref="MapProvider.None"/> when no provider is active or its key is empty.
        /// </remarks>
        [Key(7)]
        [JsonPropertyOrder(7)]
        public MapProvider MapProvider { get; init; }

        /// <summary>
        /// Api key of the active map provider; null when <see cref="MapProvider"/> is <see cref="MapProvider.None"/>.
        /// </summary>
        [Key(8)]
        [JsonPropertyOrder(8)]
        public string? MapApiKey { get; init; }

        /// <summary>
        /// Label above the welcome title.
        /// </summary>
        [Key(9)]
        [JsonPropertyOrder(9)]
        public string? WelcomeLabel { get; init; }

        /// <summary>
        /// First line of the welcome slogan.
        /// </summary>
        [Key(10)]
        [JsonPropertyOrder(10)]
        public string? WelcomeSloganLine1 { get; init; }

        /// <summary>
        /// Second line of the welcome slogan.
        /// </summary>
        [Key(11)]
        [JsonPropertyOrder(11)]
        public string? WelcomeSloganLine2 { get; init; }

        /// <summary>
        /// Description below the welcome slogan.
        /// </summary>
        [Key(12)]
        [JsonPropertyOrder(12)]
        public string? WelcomeDescription { get; init; }
    }
}
