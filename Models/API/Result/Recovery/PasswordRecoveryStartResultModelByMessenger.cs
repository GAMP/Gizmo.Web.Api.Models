using MessagePack;

using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Password recovery by messenger start result.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PasswordRecoveryStartResultModelByMessenger
    {
        #region PROPERTIES

        /// <summary>
        /// Recovery result code.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public PasswordRecoveryStartResultCode Result { get; set; }

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

        #endregion
    }
}
