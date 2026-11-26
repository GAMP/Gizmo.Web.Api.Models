namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refers to a person: an operator, a player or a guest, who share one user id space.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationPersonReferenceModel : ConversationReferenceModel
    {
        /// <summary>
        /// The user id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserId { get; init; }
    }
}
