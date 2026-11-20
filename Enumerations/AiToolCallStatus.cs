using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// AI tool call outcomes.
    /// </summary>
    /// <remarks>
    /// JSON carries the lowercase names below; MessagePack keeps the underlying integer value.
    /// </remarks>
    [JsonConverter(typeof(JsonStringEnumConverter<AiToolCallStatus>))]
    public enum AiToolCallStatus
    {
        /// <summary>
        /// The tool ran and returned its result.
        /// </summary>
        [JsonStringEnumMemberName("succeeded")]
        Succeeded = 0,

        /// <summary>
        /// The tool ran and failed.
        /// </summary>
        [JsonStringEnumMemberName("failed")]
        Failed = 1,

        /// <summary>
        /// The call was denied by authorization and did not run.
        /// </summary>
        [JsonStringEnumMemberName("denied")]
        Denied = 2,
    }
}
