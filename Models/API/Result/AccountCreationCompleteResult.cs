using Gizmo;
using Gizmo.Web.Api.Models;
using MessagePack;
using System.Text.Json.Serialization;

namespace ServerService
{
    /// <summary>
    /// Account creation complete result model.
    /// </summary>
    /// <remarks>
    /// Used with non-verified account creation.
    /// </remarks>
    [MessagePackObject()]
    public sealed class AccountCreationCompleteResult : ResultCodeBase<AccountCreationCompleteResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Newly created user id.
        /// </summary>
        [Key(1)]
        [JsonPropertyOrder(1)]
        public int? CreatedUserId
        {
            get; set;
        }

        #endregion
    } 
}
