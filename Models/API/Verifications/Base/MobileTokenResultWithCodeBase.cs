#nullable enable

using MessagePack;
using System;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base verification result for mobile phones.
    /// </summary>
    public abstract class MobileTokenResultWithCodeBase<TResultCode> : TokenResultWithCodeBase<TResultCode> where TResultCode : Enum
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public virtual string? MobilePhone
        {
            get; set;
        }

        /// <summary>
        /// Gets confirmation code delivery method.
        /// </summary>
        /// <remarks>
        /// The default value is <see cref="ConfirmationCodeDeliveryMethod.Undetermined"/>.
        /// </remarks>
        [Key(4)]
        [JsonPropertyOrder(4)]
        public ConfirmationCodeDeliveryMethod DeliveryMethod
        {
            get; init;
        } = ConfirmationCodeDeliveryMethod.Undetermined;

        #endregion
    }
}
