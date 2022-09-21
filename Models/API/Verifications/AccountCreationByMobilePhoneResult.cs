using ProtoBuf;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by mobile phone result model.
    /// </summary>
    [ProtoContract()]
    public class AccountCreationByMobilePhoneResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Mobile phone used.
        /// </summary>
        [ProtoMember(1)]
        public string MobilePhone
        {
            get; set;
        }

        #endregion
    }
}
