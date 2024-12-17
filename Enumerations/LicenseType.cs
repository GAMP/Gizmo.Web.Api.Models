using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License type.
    /// </summary>
    public enum LicenseType
    {
        /// <summary>
        /// Undetermined.
        /// </summary>
        [Name("Undetermined", "LICENSE_TYPE_UNDETERMINED_NAME")]
        [ExtendedDescription("License type is undetermined", "LICENSE_TYPE_UNDETERMINED_DESCRIPTION")]
        Undetermined,
        /// <summary>
        /// Trial.
        /// </summary>
        [Name("Trial", "LICENSE_TYPE_TRIAL_NAME")]
        [ExtendedDescription("Trial license", "LICENSE_TYPE_TRIAL_DESCRIPTION")]
        Trial,
        /// <summary>
        /// Normal subscription.
        /// </summary>
        [Name("Normal", "LICENSE_TYPE_NORMAL_NAME")]
        [ExtendedDescription("Normal license", "LICENSE_TYPE_NORMAL_DESCRIPTION")]
        Normal,
    }
}
