using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// System process module model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemProcessModuleModel : IWebApiModel
    {
        /// <summary>
        /// File name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? FileName { get; init; }

        /// <summary>
        /// File version.
        /// </summary>
        [MessagePack.Key(1)]
        public string? FileVersion { get; init; }

        /// <summary>
        /// Module name.
        /// </summary>
        [MessagePack.Key(2)]
        public string? ModuleName { get; init; }

        /// <summary>
        /// Company name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? CompanyName { get; init; }

        /// <summary>
        /// Description.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Description { get; init; }

        /// <summary>
        /// File icon.
        /// </summary>
        [MessagePack.Key(5)]
        public byte[] Icon { get; set; } = Array.Empty<byte>();
    }
}
