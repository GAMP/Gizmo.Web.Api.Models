using ProtoBuf;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by email result model.
    /// </summary>
    [ProtoContract()]
    public class AccountCreationByEmailResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Email address used.
        /// </summary>
        [ProtoMember(1)]
        public string EmailAddress
        {
            get; set;
        }

        #endregion
    }
}
