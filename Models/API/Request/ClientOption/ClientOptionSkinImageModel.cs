using System;
using Gizmo.Web.Api.Models.Enumerations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option skin image.
    /// </summary>
    [MessagePackObject]
    public sealed class ClientOptionSkinImageModel
    {
        [MessagePack.Key(0)]
        public SkinImageType ImageType { get; set; }

        [MessagePack.Key(1)]
        public string ImageName { get; set; } = string.Empty;

        [MessagePack.Key(2)]
        public byte[] Image { get; set; } = Array.Empty<byte>();
    }
}
