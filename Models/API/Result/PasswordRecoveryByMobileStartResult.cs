using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Password recovery by mobile start result.
    /// </summary>
    [MessagePackObject()]
    public sealed class PasswordRecoveryByMobileStartResult : MobileTokenResultWithCodeBase<PasswordRecoveryStartResultCode>
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets mobile phone used to recover the password.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public override string MobilePhone { get => base.MobilePhone; set => base.MobilePhone = value; } 

        #endregion
    }
}
