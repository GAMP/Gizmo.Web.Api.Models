#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostIconModelUpdate : IHostIconApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        [Key(1)]
        public byte[] Image { get; set; } = Array.Empty<byte>();

        #endregion
    }
}
