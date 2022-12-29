using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable image.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableImage : IImageApiModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        [Key(0)]
        public byte[] Image { get; set; }
    }
}