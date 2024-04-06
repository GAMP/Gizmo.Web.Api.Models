namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Screen capture parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScreenCaptureParametersModel
    {
        /// <summary>
        /// Image resize width.
        /// </summary>
        [MessagePack.Key(0)]
        public int Width
        {
            get; init;
        }

        /// <summary>
        /// Image resize height.
        /// </summary>
        [MessagePack.Key(1)]
        public int Height
        {
            get; init;
        }

        /// <summary>
        /// Image quality.
        /// </summary>
        [MessagePack.Key(2)]
        public int ImageQuality
        {
            get; init;
        }
    }
}
