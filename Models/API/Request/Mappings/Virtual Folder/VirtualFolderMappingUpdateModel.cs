namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Virtual folder create/update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class VirtualFolderMappingUpdateModel : IWebApiModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

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
        /// Direct access.
        /// </summary>
        [MessagePack.Key(3)]
        public bool DirectAccess { get; init; }

        /// <summary>
        /// Read only.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsReadOnly { get; init; }
    }
}
