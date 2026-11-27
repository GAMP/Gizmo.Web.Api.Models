namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A support conversation was handed from the support bot to support agents.
    /// </summary>
    /// <remarks>
    /// Visible to everyone, so the operator knows a person will answer.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ConversationHandedOffEventModel : ConversationEntryModel
    {
    }
}
