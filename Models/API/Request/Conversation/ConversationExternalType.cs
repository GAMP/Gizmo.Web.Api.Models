using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The type of a participant on the support side of a conversation, in Gizmo support's helpdesk (Chatwoot).
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ConversationExternalType>))]
    public enum ConversationExternalType
    {
        /// <summary>
        /// A support agent: a person in the helpdesk.
        /// </summary>
        [JsonStringEnumMemberName("agent")]
        Agent = 0,

        /// <summary>
        /// The support bot.
        /// </summary>
        [JsonStringEnumMemberName("bot")]
        Bot = 1,

        /// <summary>
        /// The support side as a whole, when the helpdesk does not say which agent or bot acted; its id is always 0.
        /// </summary>
        [JsonStringEnumMemberName("helpdesk")]
        Helpdesk = 2,
    }
}
