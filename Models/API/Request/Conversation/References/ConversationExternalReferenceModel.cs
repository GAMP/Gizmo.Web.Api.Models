namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refers to a participant on the support side of a support conversation: a support agent or the support bot in Gizmo support's helpdesk (Chatwoot).
    /// </summary>
    /// <remarks>
    /// Created by the server only; requests cannot mention or add external participants.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationExternalReferenceModel : ConversationReferenceModel
    {
        /// <summary>
        /// Whether the participant is an agent, the bot or the helpdesk as a whole.
        /// </summary>
        [MessagePack.Key(2)]
        public ConversationExternalType ExternalType { get; init; }

        /// <summary>
        /// The participant's id in the helpdesk: the Chatwoot user id of an agent, the agent bot id of the bot, 0 for the helpdesk.
        /// </summary>
        [MessagePack.Key(3)]
        public int ExternalId { get; init; }
    }
}
