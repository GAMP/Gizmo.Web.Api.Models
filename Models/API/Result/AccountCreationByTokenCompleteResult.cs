using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by token result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class AccountCreationByTokenCompleteResult : TokenResultWithCodeBase<AccountCreationByTokenCompleteResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Newly created user id.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public int? CreatedUserId
        {
            get; set;
        }

        #endregion
    }
}
