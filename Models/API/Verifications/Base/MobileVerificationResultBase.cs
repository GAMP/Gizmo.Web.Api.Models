#nullable enable

using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base verification result for mobile phones.
    /// </summary>
    [MessagePackObject()]
    [Union(0,typeof(MobilePhoneVerificationStartResult))]
    public abstract class MobileVerificationResultBase<TResultCode> : TokenResultWithCodeBase<TResultCode> where TResultCode : Enum
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="mobilePhone">Mobile phone.</param>
        public MobileVerificationResultBase(string mobilePhone)
        {
            MobilePhone = mobilePhone;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets mobile phone beign verified.
        /// </summary>
        /// <remarks>
        /// This value will always be set even in case of failure.
        /// </remarks>
        [Key(3)]
        public string MobilePhone
        {
            get; init;
        }

        /// <summary>
        /// Gets confirmation code delivery method.
        /// </summary>
        /// <remarks>
        /// The default value is <see cref="ConfirmationCodeDeliveryMethod.Undetermined"/>.
        /// </remarks>
        [Key(4)]
        public ConfirmationCodeDeliveryMethod DeliveryMethod
        {
            get; init;
        } = ConfirmationCodeDeliveryMethod.Undetermined;

        #endregion
    }
}
