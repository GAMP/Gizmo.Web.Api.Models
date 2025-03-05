namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security policy metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityPolicyMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Policy name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Policy description.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Description { get; init; }

        /// <summary>
        /// Policy type.
        /// </summary>
        [MessagePack.Key(2)]
        public int Type { get; init; }

        /// <summary>
        /// Policy group.
        /// </summary>
        [MessagePack.Key(3)]
        public int Group { get; init; }
    }
}
