using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by mobile phone result model.
    /// </summary>
    [MessagePackObject()]
    public sealed class AccountCreationByMobilePhoneResult : MobileTokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets mobile phone used to create the account.
        /// </summary>
        [Key(3)]
        [JsonPropertyOrder(3)]
        public override string MobilePhone { get => base.MobilePhone; set => base.MobilePhone = value; }

        #endregion
    }
}
