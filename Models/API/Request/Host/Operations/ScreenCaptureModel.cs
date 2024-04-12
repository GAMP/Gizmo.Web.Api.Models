using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Screen capture model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScreenCaptureModel : IWebApiModel
    {
        /// <summary>
        /// Capture width.
        /// </summary>
        [MessagePack.Key(0)]
        public int Width
        {
            get;init;
        }

        /// <summary>
        /// Capture height.
        /// </summary>
        [MessagePack.Key(1)]
        public int Height
        {
            get;init;
        }

        /// <summary>
        /// X position.
        /// </summary>
        [MessagePack.Key(2)]
        public int X
        {
            get;init;
        }

        /// <summary>
        /// Y position.
        /// </summary>
        [MessagePack.Key(3)]
        public int Y
        {
            get;init;
        }

        /// <summary>
        /// Image data.
        /// </summary>
        [MessagePack.Key(4)]
        public byte[] Data
        {
            get; init;
        } = Array.Empty<byte>();
    }
}
