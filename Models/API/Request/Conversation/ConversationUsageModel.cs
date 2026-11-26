using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Tokens an AI turn used, as far as the provider reports them.
    /// </summary>
    /// <remarks>
    /// Sent to staff only.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationUsageModel : IWebApiModel
    {
        /// <summary>
        /// Input tokens.
        /// </summary>
        [MessagePack.Key(0)]
        public int? InputTokens { get; init; }

        /// <summary>
        /// Output tokens.
        /// </summary>
        [MessagePack.Key(1)]
        public int? OutputTokens { get; init; }
    }
}
