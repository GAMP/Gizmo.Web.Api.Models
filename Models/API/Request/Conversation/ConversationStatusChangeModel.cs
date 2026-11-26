using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Closes or reopens a conversation.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationStatusChangeModel : IWebApiModel
    {
        /// <summary>
        /// Why, if given.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Reason { get; init; }
    }
}
