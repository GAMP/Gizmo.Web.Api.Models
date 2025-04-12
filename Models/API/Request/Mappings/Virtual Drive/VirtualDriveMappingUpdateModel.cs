using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Virtual drive mapping update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class VirtualDriveMappingUpdateModel : IWebApiModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Label.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public string Label { get; init; } = null!;

        /// <summary>
        /// Source.
        /// </summary>
        [MessagePack.Key(2)]
        public string Source { get; init; } = null!;

        /// <summary>
        /// Mount point.
        /// </summary>
        [MessagePack.Key(3)]
        public string MountPoint { get; init; } = null!;

        /// <summary>
        /// Size.
        /// </summary>
        [MessagePack.Key(4)]
        public long Size { get; init; }

        /// <summary>
        /// Direct access.
        /// </summary>
        [MessagePack.Key(5)]
        public bool DirectAccess { get; init; } = false;

        /// <summary>
        /// Read only.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsReadOnly { get; init; } = false;
    }
}
