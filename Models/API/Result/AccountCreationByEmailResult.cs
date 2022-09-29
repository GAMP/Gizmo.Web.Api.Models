using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by email result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class AccountCreationByEmailResult : EmailTokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets email used to create the account.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public override string Email { get => base.Email; set => base.Email = value; }

        #endregion
    }
}
