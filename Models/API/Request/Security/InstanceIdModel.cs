namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance id model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InstanceIdModel : IWebApiModel
    {
        /// <summary>
        /// Instance id type.
        /// </summary>
        [MessagePack.Key(0)]
        public InstanceIdType Type { get; init; }

        /// <summary>
        /// Gets instance id value.
        /// </summary>
        [MessagePack.Key(1)]
        public string Value { get; init; } = null!;
    }
}
