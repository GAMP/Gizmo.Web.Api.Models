using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by mobile phone result model.
    /// </summary>
    [MessagePackObject()]
    public class AccountCreationByMobilePhoneResult : TokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Mobile phone used.
        /// </summary>
        [Key(4)]
        public string MobilePhone
        {
            get; set;
        }

        /// <summary>
        /// Gets confirmation code delivery method.
        /// </summary>
        [Key(5)]
        public ConfirmationCodeDeliveryMethod DeliveryMethod
        {
            get; init;
        }

        #endregion
    }
}
