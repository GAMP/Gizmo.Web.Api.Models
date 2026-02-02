using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User member ban reason model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserMemberBanReasonModel : IWebApiModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(1)]
        public required string Name { get; init; }

        /// <summary>
        /// Description.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; init; }
    }
}
