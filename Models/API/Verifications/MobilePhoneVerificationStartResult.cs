using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mobile phone verification start result model.
    /// </summary>
    [MessagePackObject()]
    public class MobilePhoneVerificationStartResult : TokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Mobile phone being verified.
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
