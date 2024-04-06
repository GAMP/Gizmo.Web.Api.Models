using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Screen capture parameters.
    /// </summary>
    public sealed class ScreenCaptureParametersModel : IUriParametersQuery
    {
        /// <summary>
        /// Image resize width.
        /// </summary>
        public int Width
        {
            get; init;
        }

        /// <summary>
        /// Image resize height.
        /// </summary>
        public int Height
        {
            get; init;
        }

        /// <summary>
        /// Image quality.
        /// </summary>
        public int ImageQuality
        {
            get; init;
        }
    }
}
