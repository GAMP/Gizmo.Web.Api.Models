using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Password change model.
    /// </summary>
    public sealed class RecoveryPasswordChangeModel : IUriParametersQuery
    {
        /// <summary>
        /// New password.
        /// </summary>
        public string NewPassword { get; init; } = string.Empty;
    }
}
