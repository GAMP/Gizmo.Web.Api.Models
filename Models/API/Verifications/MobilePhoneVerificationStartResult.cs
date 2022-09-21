using ProtoBuf;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mobile phone verification start result model.
    /// </summary>
    [ProtoContract()]
    public class MobilePhoneVerificationStartResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Mobile phone being verified.
        /// </summary>
        [ProtoMember(1)]
        public string MobilePhone
        {
            get; set;
        }

        #endregion
    }
}
