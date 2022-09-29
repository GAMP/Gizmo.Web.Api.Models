using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mobile phone verification start result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class MobilePhoneVerificationStartResult : MobileTokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets mobile phone being verified.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public override string MobilePhone { get => base.MobilePhone; set => base.MobilePhone = value; } 

        #endregion
    }
}
