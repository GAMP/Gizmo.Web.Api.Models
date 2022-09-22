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
    [MessagePack.MessagePackObject()]
    [MessagePack.Union(0, typeof(EmailVerificationStartResult))]
    [MessagePack.Union(1, typeof(MobilePhoneVerificationStartResult))]
    [MessagePack.Union(2, typeof(AccountCreationByMobilePhoneResult))]
    [MessagePack.Union(3, typeof(AccountCreationByEmailResult))]
    public abstract class VerificationResultBase<T> where T : Enum
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [ProtoMember(1)]
        [MessagePack.Key(0)]
        public T Result
        {
            get; set;
        }

        /// <summary>
        /// Confirmation code.
        /// </summary>
        [ProtoMember(2)]
        [MessagePack.Key(1)]
        public string ConfirmationCode
        {
            get; set;
        }

        /// <summary>
        /// Token value.
        /// </summary>
        [ProtoMember(3)]
        [MessagePack.Key(2)]
        public string Token
        {
            get; set;
        }

        /// <summary>
        /// Token id.
        /// </summary>
        [ProtoMember(4)]
        [MessagePack.Key(3)]
        public int? TokenId
        {
            get; set;
        }

        #endregion
    }
}
