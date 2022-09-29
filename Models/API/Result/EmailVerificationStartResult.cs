using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Email verification start result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class EmailVerificationStartResult : EmailTokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets email address being verified.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public override string Email { get => base.Email; set => base.Email = value; } 

        #endregion
    }
}
