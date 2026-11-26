using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Who may see a conversation entry.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ConversationVisibility>))]
    public enum ConversationVisibility
    {
        /// <summary>
        /// Every participant.
        /// </summary>
        [JsonStringEnumMemberName("everyone")]
        Everyone = 0,

        /// <summary>
        /// Staff participants only.
        /// </summary>
        [JsonStringEnumMemberName("staff")]
        Staff = 1,
    }
}
