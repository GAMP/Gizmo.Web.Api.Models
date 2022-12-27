using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application
{
    /// <summary>
    /// Application image.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationImage : IImageApiModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }
    }
}