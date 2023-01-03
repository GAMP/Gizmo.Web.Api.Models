#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation complete result model.
    /// </summary>
    /// <remarks>
    /// Used with non-verified account creation.
    /// </remarks>
    [MessagePackObject]
    public sealed class AccountCreationCompleteResult : IResultCode<AccountCreationCompleteResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [Key(0)]
        [JsonPropertyOrder(0)]
        public AccountCreationCompleteResultCode Result { get; set; }

        /// <summary>
        /// Newly created user id.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public int? CreatedUserId { get; set; }

        #endregion
    }
}
