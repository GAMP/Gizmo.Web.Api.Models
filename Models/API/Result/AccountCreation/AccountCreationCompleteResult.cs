using Gizmo.Web.Api.Models.Abstractions.Models.API.Result;

using MessagePack;

using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models.Models.API.Result.AccountCreation
{
    /// <summary>
    /// Account creation complete result model.
    /// </summary>
    /// <remarks>
    /// Used with non-verified account creation.
    /// </remarks>
    [MessagePackObject()]
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
