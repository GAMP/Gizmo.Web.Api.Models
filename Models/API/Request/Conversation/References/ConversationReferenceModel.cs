using System.Text.Json.Serialization;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refers to a conversation participant: an author, a subject or a mention.
    /// </summary>
    /// <remarks>
    /// A participant is identified by its kind and id. <see cref="DisplayName"/> and <see cref="Role"/> are looked up
    /// live for the recipient and ignored in requests. In JSON the <c>kind</c> discriminator comes first.
    /// </remarks>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
    [JsonDerivedType(typeof(ConversationPersonReferenceModel), "person")]
    [JsonDerivedType(typeof(ConversationAIReferenceModel), "ai")]
    [JsonDerivedType(typeof(ConversationExternalReferenceModel), "external")]
    [MessagePack.Union(0, typeof(ConversationPersonReferenceModel))]
    [MessagePack.Union(1, typeof(ConversationAIReferenceModel))]
    [MessagePack.Union(2, typeof(ConversationExternalReferenceModel))]
    public abstract class ConversationReferenceModel : IWebApiModel
    {
        /// <summary>
        /// The name shown for the participant.
        /// </summary>
        [MessagePack.Key(0)]
        public string? DisplayName { get; init; }

        /// <summary>
        /// The participant's current role.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Role { get; init; }
    }
}
