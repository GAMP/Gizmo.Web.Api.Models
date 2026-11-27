using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A model an AI chat connection offers.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationAIModelInfoModel : IWebApiModel
    {
        /// <summary>
        /// The model id within the connection.
        /// </summary>
        [MessagePack.Key(0)]
        public string ModelId { get; init; } = string.Empty;

        /// <summary>
        /// The name shown for the model.
        /// </summary>
        [MessagePack.Key(1)]
        public string DisplayName { get; init; } = string.Empty;

        /// <summary>
        /// Whether the model can call tools.
        /// </summary>
        [MessagePack.Key(2)]
        public bool SupportsTools { get; init; }
    }
}
