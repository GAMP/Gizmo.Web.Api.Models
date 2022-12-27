#nullable enable

using Gizmo;
using Gizmo.Web.Api.Models.Abstractions.Models.API.Result;
using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models.Models.API.Result.Recovery
{
    /// <summary>
    /// Password recovery by email start result.
    /// </summary>
    [MessagePackObject()]
    public sealed class PasswordRecoveryByEmailStartResult : IEmailTokenResultWithCode<PasswordRecoveryStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
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

        /// <summary>
        /// Gets or sets email used to recover the password.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public string Email { get; set; } = null!;

        #endregion
    }
}
