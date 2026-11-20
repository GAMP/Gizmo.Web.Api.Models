using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// AI chat session creation model.
    /// </summary>
    /// <remarks>
    /// Both values are admitted and resolved server side; selecting a connection grants nothing by
    /// itself, and a session is bound to the authenticated caller rather than to a request field.
    /// </remarks>
    [MessagePackObject]
    public sealed class AiSessionCreateModel : IWebApiModel
    {
        /// <summary>
        /// The configured connection to chat through, given by its existing integration id.
        /// </summary>
        [Key(0)]
        public int ConnectionId { get; set; }

        /// <summary>
        /// The opaque model identifier to use on that connection.
        /// </summary>
        [Key(1)]
        public string ModelId { get; set; } = null!;
    }
}
