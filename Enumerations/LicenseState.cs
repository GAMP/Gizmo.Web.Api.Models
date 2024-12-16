namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License state.
    /// </summary>
    public enum LicenseState
    {
        /// <summary>
        /// Valid.
        /// </summary>
        Valid,
        /// <summary>
        /// Disabled instance.
        /// </summary>
        DisabledInstanceId,
        /// <summary>
        /// Disabled license.
        /// </summary>
        Disabled,
        /// <summary>
        /// Expired.
        /// </summary>
        Expired,
        /// <summary>
        /// Unauthorized.
        /// </summary>
        Unauthorized,
        /// <summary>
        /// License is invalid.
        /// </summary>
        Invalid,
    }
}
