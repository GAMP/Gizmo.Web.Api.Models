using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A participant to add or remove.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationParticipantModel : IWebApiModel
    {
        /// <summary>
        /// The participant.
        /// </summary>
        [MessagePack.Key(0)]
        public ConversationReferenceModel Reference { get; init; } = null!;
    }
}
