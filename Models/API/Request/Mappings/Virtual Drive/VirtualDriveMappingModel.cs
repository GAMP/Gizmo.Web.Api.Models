namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Virtual drive mapping model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class VirtualDriveMappingModel : MappingModel
    {
        /// <summary>
        /// Size.
        /// </summary>
        [MessagePack.Key(3)]
        public long Size { get; init; }

        /// <summary>
        /// Read only.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsReadOnly { get; init; }

        /// <summary>
        /// Direct access.
        /// </summary>
        [MessagePack.Key(5)]
        public bool DirectAccess { get; init; }
    }
}
