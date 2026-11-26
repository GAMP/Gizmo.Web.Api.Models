using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Why an AI turn ended without a reply.
    /// </summary>
    /// <remarks>
    /// The provider's failure statuses, plus <see cref="Cancelled"/> and <see cref="ConnectionNotFound"/> set by the server.
    /// </remarks>
    [JsonConverter(typeof(JsonStringEnumConverter<ConversationAITurnFailureStatus>))]
    public enum ConversationAITurnFailureStatus
    {
        /// <summary>
        /// The turn failed for another reason.
        /// </summary>
        [JsonStringEnumMemberName("failed")]
        Failed = 0,

        /// <summary>
        /// The model provider rejected the credentials.
        /// </summary>
        [JsonStringEnumMemberName("unauthorized")]
        Unauthorized = 1,

        /// <summary>
        /// The model provider is limiting requests.
        /// </summary>
        [JsonStringEnumMemberName("rateLimited")]
        RateLimited = 2,

        /// <summary>
        /// The model does not exist at the provider.
        /// </summary>
        [JsonStringEnumMemberName("modelNotFound")]
        ModelNotFound = 3,

        /// <summary>
        /// The conversation does not fit the model.
        /// </summary>
        [JsonStringEnumMemberName("contextTooLong")]
        ContextTooLong = 4,

        /// <summary>
        /// The model refused to answer.
        /// </summary>
        [JsonStringEnumMemberName("refused")]
        Refused = 5,

        /// <summary>
        /// The model provider could not be reached.
        /// </summary>
        [JsonStringEnumMemberName("unavailable")]
        Unavailable = 6,

        /// <summary>
        /// The turn was stopped before it finished, for example by a server shutdown.
        /// </summary>
        [JsonStringEnumMemberName("cancelled")]
        Cancelled = 7,

        /// <summary>
        /// No enabled AI chat connection matches the AI participant.
        /// </summary>
        [JsonStringEnumMemberName("connectionNotFound")]
        ConnectionNotFound = 8,
    }
}
