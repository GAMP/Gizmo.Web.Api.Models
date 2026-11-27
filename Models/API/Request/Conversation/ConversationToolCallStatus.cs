using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// How a tool call ended.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ConversationToolCallStatus>))]
    public enum ConversationToolCallStatus
    {
        /// <summary>
        /// The tool ran and returned its result.
        /// </summary>
        [JsonStringEnumMemberName("succeeded")]
        Succeeded = 0,

        /// <summary>
        /// The call was refused: the caller may not use the tool, or the turn's call limit was reached.
        /// </summary>
        [JsonStringEnumMemberName("denied")]
        Denied = 1,

        /// <summary>
        /// The tool failed.
        /// </summary>
        [JsonStringEnumMemberName("failed")]
        Failed = 2,
    }
}
