using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The purpose of a conversation, fixed when it is created.
    /// </summary>
    /// <remarks>
    /// The purpose decides how the AI behaves by default; the participants may change over time, the purpose does not.
    /// </remarks>
    [JsonConverter(typeof(JsonStringEnumConverter<ConversationPurpose>))]
    public enum ConversationPurpose
    {
        /// <summary>
        /// A person works with the AI.
        /// </summary>
        [JsonStringEnumMemberName("assistant")]
        Assistant = 0,

        /// <summary>
        /// A customer talks with the venue's staff.
        /// </summary>
        [JsonStringEnumMemberName("internal")]
        Internal = 1,

        /// <summary>
        /// The venue talks with Gizmo support.
        /// </summary>
        [JsonStringEnumMemberName("support")]
        Support = 2,
    }
}
