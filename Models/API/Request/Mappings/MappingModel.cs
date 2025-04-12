namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mapping model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    [MessagePack.Union(0,typeof(NetworkDriveMappingModel))]
    [MessagePack.Union(1, typeof(VirtualDriveMappingModel))]
    [MessagePack.Union(2, typeof(VirtualFolderMappingModel))]
    public abstract class MappingModel : IMappingModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string MountPoint { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string Source { get; init; } = null!;
    }
}
