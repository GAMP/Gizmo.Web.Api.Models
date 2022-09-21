using ProtoBuf;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base class for verfication results.
    /// </summary>
    /// <typeparam name="T">Result type.</typeparam>
    [ProtoContract()]
    [ProtoInclude(500, typeof(EmailVerificationStartResult))]
    [ProtoInclude(501, typeof(MobilePhoneVerificationStartResult))]
    [ProtoInclude(502, typeof(AccountCreationByMobilePhoneResult))]
    [ProtoInclude(503, typeof(AccountCreationByEmailResult))]
    public abstract class VerificationResultBase<T> where T : Enum
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [ProtoMember(1)]
        public T Result
        {
            get; set;
        }

        /// <summary>
        /// Confirmation code.
        /// </summary>
        [ProtoMember(2)]
        public string ConfirmationCode
        {
            get; set;
        }

        /// <summary>
        /// Token value.
        /// </summary>
        [ProtoMember(3)]
        public string Token
        {
            get; set;
        }

        /// <summary>
        /// Token id.
        /// </summary>
        [ProtoMember(4)]
        public int? TokenId
        {
            get; set;
        }

        #endregion
    }
}
