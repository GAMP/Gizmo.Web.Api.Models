using ProtoBuf;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by mobile phone result model.
    /// </summary>
    [ProtoContract()]
    [MessagePack.MessagePackObject()]
    public class AccountCreationByMobilePhoneResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Mobile phone used.
        /// </summary>
        [ProtoMember(1)]
        [MessagePack.Key(5)]
        public string MobilePhone
        {
            get; set;
        }

        #endregion
    }
}
