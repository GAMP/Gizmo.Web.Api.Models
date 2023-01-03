#nullable enable

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User picture.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPicture
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Key(0)]
        public byte[] Picture { get; set; } = Array.Empty<byte>();

        #endregion
    }
}