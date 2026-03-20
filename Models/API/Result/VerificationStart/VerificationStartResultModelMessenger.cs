using MessagePack;

using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Messenger verification start result model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class VerificationStartResultModelMessenger
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
        public string? Token { get; set; } = null!;

        /// <summary>
        /// Gets the messenger start link URL.
        /// </summary>
        [Key(2)]
        [JsonPropertyOrder(2)]
        public string? StartLink { get; set; } = null!;

        #endregion
    }
}
