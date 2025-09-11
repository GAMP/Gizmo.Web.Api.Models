using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option skin image.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ClientOptionSkinImageModel
    {
        /// <summary>
        /// Image type.
        /// </summary>
        [MessagePack.Key(0)]
        public SkinImageType ImageType { get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        [MessagePack.Key(1)]
        public string ImageName { get; set; } = string.Empty;

        /// <summary>
        /// Image.
        /// </summary>
        [MessagePack.Key(2)]
        public byte[] Image { get; set; } = Array.Empty<byte>();
    }
}
