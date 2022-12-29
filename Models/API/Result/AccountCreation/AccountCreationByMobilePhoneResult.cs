﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.API.Result;

using MessagePack;

using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by mobile phone result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class AccountCreationByMobilePhoneResult : IMobileTokenResultWithCode<VerificationStartResultCode>
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
        /// Gets or sets mobile phone used to create the account.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public string MobilePhone { get; set; } = null!;

        /// <summary>
        /// Gets confirmation code delivery method.
        /// </summary>
        /// <remarks>
        /// The default value is <see cref="ConfirmationCodeDeliveryMethod.Undetermined"/>.
        /// </remarks>
        [Key(4)]
        [JsonPropertyOrder(4)]
        public ConfirmationCodeDeliveryMethod DeliveryMethod { get; init; } = ConfirmationCodeDeliveryMethod.Undetermined;

        #endregion
    }
}
