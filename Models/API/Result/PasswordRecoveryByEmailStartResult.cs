using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Password recovery by email start result.
    /// </summary>
    [MessagePackObject()]
    public sealed class PasswordRecoveryByEmailStartResult : EmailTokenResultWithCodeBase<PasswordRecoveryStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets email used to recover the password.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public override string Email { get => base.Email; set => base.Email = value; }

        #endregion
    }
}
