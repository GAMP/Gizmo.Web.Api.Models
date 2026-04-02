namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Specifies how a verification operation should be delivered.
    /// </summary>
    public enum VerificationDeliveryMethod
    {
        /// <summary>
        /// Generate a redirect URL (deep link, OAuth) for the user to visit.
        /// </summary>
        Redirect = 0,

        /// <summary>
        /// Dispatch a confirmation code to a known recipient.
        /// </summary>
        CodeDispatch = 1,
    }
}
