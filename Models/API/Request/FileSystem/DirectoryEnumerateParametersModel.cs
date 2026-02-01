namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Directory enumeration parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DirectoryEnumerateParametersModel 
    {
        /// <summary>
        /// Enumeration path.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }
    }
}
