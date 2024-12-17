using System.ComponentModel.DataAnnotations;

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
        [Name("Valid", "LICENSE_STATE_VALID_NAME")]
        [ExtendedDescription("Valid", "LICENSE_STATE_SUCCESS_DESCRIPTION")]
        Valid,

        /// <summary>
        /// Disabled instance.
        /// </summary>
        [Name("Disabled instance id", "LICENSE_STATE_DISABLED_INSTANCE_ID_NAME")]
        [ExtendedDescription("Instance id is disabled/blocked", "LICENSE_STATE_DISABLED_INSTANCE_ID_DESCRIPTION")]
        DisabledInstanceId,

        /// <summary>
        /// Disabled license.
        /// </summary>
        [Name("Disabled", "LICENSE_STATE_DISABLED_NAME")]
        [ExtendedDescription("License is disabled", "LICENSE_STATE_DISABLED_DESCRIPTION")]
        Disabled,

        /// <summary>
        /// Expired.
        /// </summary>
        [Name("Expired", "LICENSE_STATE_EXPIRED_NAME")]
        [ExtendedDescription("License is expired", "LICENSE_STATE_EXPIRED_DESCRIPTION")]
        Expired,

        /// <summary>
        /// Unauthorized.
        /// </summary>
        [Name("Unauthorized", "LICENSE_STATE_UNAUTHORIZED_NAME")]
        [ExtendedDescription("Unauthorized", "LICENSE_STATE_UNAUTHORIZED_DESCRIPTION")]
        Unauthorized,

        /// <summary>
        /// License is invalid.
        /// </summary>
        [Name("Invalid", "LICENSE_STATE_INVALID_NAME")]
        [ExtendedDescription("Local license is invalid", "LICENSE_STATE_INVALID_DESCRIPTION")]
        Invalid,
    }
}
