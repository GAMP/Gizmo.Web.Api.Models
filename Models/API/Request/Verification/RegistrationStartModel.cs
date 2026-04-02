using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Registration start request.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Phone number to verify for registration.
        /// Required when delivery method is <see cref="VerificationDeliveryMethod.CodeDispatch"/>
        /// and the provider dispatches via phone (e.g. SMS).
        /// </summary>
        [Key(2)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Email address to verify for registration.
        /// Required when delivery method is <see cref="VerificationDeliveryMethod.CodeDispatch"/>
        /// and the provider dispatches via email.
        /// </summary>
        [Key(3)]
        public string? Email { get; set; }
    }
}
