namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Policy group metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PolicyGroupMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Policy group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string PolicyGroupName { get; init; } = null!;

        /// <summary>
        /// Root policy name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? RootPolicyName { get; init; } = null!;

        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(2)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Description.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Description { get; init; } = null!;
    }
}
