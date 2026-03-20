using MessagePack;

using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by messenger result model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AccountCreationResultModelByMessenger
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public VerificationStartResultCode Result { get; set; }

        /// <summary>
        /// Token value.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Gets confirmation code length.
        /// </summary>
        [Key(2)]
        [JsonPropertyOrder(2)]
        public int CodeLength { get; init; }

        /// <summary>
        /// Gets the messenger start link URL.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public string StartLink { get; set; } = null!;

        #endregion
    }
}
