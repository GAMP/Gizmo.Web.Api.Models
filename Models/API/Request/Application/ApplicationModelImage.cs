﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application image.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationModelImage : IImageApiModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        [Key(0)]
        public byte[] Image { get; set; } = Array.Empty<byte>();
    }
}