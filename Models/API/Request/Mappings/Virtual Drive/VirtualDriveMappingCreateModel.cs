using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Virtual drive mapping create/update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class VirtualDriveMappingCreateModel : IWebApiModel
    {
        /// <summary>
        /// Label.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public string Label { get; init; } = null!;

        /// <summary>
        /// Source.
        /// </summary>
        [MessagePack.Key(1)]
        public string Source { get; init; } = null!;

        /// <summary>
        /// Mount point.
        /// </summary>
        [MessagePack.Key(2)]
        public string MountPoint { get; init; } = null!;

        /// <summary>
        /// Size.
        /// </summary>
        [MessagePack.Key(3)]
        public long Size { get; init; }

        /// <summary>
        /// Direct access.
        /// </summary>
        [MessagePack.Key(4)]
        public bool DirectAccess { get; init; } = false;

        /// <summary>
        /// Read only.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsReadOnly { get; init; } = false;
    }
}
