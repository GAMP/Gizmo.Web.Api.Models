using MessagePack;
using ProtoBuf;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mobile phone verification start result model.
    /// </summary>
    [ProtoContract()]
    [MessagePackObject()]
    public class MobilePhoneVerificationStartResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Mobile phone being verified.
        /// </summary>
        [ProtoMember(1)]
        [Key(5)]
        public string MobilePhone
        {
            get; set;
        }

        #endregion
    }
}
