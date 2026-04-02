namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Specifies the purpose of a verification operation.
    /// Used to filter available providers based on required capabilities.
    /// </summary>
    public enum VerificationPurpose
    {
        /// <summary>
        /// User registration.
        /// Providers are filtered based on the configured registration verification methods.
        /// </summary>
        Registration = 0,

        /// <summary>
        /// Phone number verification.
        /// Only providers that can provide or dispatch to a phone number.
        /// </summary>
        PhoneVerification = 1,

        /// <summary>
        /// Email address verification.
        /// Only providers that can provide or dispatch to an email address.
        /// </summary>
        EmailVerification = 2,

        /// <summary>
        /// Password recovery.
        /// Providers are filtered based on the configured recovery methods.
        /// </summary>
        PasswordRecovery = 3,
    }
}
