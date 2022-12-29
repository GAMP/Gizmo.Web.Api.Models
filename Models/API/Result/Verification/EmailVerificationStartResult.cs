﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.API.Result;

using MessagePack;

using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Email verification start result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class EmailVerificationStartResult : IEmailTokenResultWithCode<VerificationStartResultCode>
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
        /// Gets or sets email address being verified.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public string Email { get; set; } = null!;

        #endregion
    }
}
