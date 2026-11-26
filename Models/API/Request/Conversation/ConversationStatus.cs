using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Conversation status, derived from its closed and reopened events.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ConversationStatus>))]
    public enum ConversationStatus
    {
        /// <summary>
        /// Messages can be sent.
        /// </summary>
        [JsonStringEnumMemberName("open")]
        Open = 0,

        /// <summary>
        /// The conversation was closed; it can be reopened.
        /// </summary>
        [JsonStringEnumMemberName("closed")]
        Closed = 1,
    }
}
