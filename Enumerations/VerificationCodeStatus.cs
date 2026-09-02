namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Dispatched verification code status.
    /// </summary>
    public enum VerificationCodeStatus
    {
        /// <summary>
        /// Code is not used yet and has not expired.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Code was used.
        /// </summary>
        Used = 1,

        /// <summary>
        /// Code was revoked.
        /// </summary>
        Revoked = 2,

        /// <summary>
        /// Code was never used and its expiration time has passed.
        /// </summary>
        Expired = 3,
    }
}
