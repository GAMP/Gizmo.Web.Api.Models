namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Virtual folder mapping model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class VirtualFolderMappingModel : MappingModel
    {
        /// <summary>
        /// Read only.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsReadOnly { get; init; }

        /// <summary>
        /// Direct access.
        /// </summary>
        [MessagePack.Key(4)]
        public bool DirectAccess { get; init; }
    }
}
