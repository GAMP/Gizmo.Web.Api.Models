namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security policy group metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityPolicyGroupMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Policy group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Policy group description.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Description { get; init; }

        /// <summary>
        /// Policy group type.
        /// </summary>
        [MessagePack.Key(2)]
        public int Type { get; init; }
    }
}
