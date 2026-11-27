using System;
using System.Text.Json.Serialization;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One entry of a conversation's history: a message, a tool call, a tool result or an event.
    /// </summary>
    /// <remarks>
    /// Entries are ordered by <see cref="Id"/>, which the server assigns and which increases within a conversation.
    /// One <c>type</c> discriminator covers messages, tool lines and every event kind. In JSON it comes first.
    /// </remarks>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(ConversationMessageModel), "message")]
    [JsonDerivedType(typeof(ConversationJoinedEventModel), "joined")]
    [JsonDerivedType(typeof(ConversationAddedEventModel), "added")]
    [JsonDerivedType(typeof(ConversationRemovedEventModel), "removed")]
    [JsonDerivedType(typeof(ConversationClosedEventModel), "closed")]
    [JsonDerivedType(typeof(ConversationReopenedEventModel), "reopened")]
    [JsonDerivedType(typeof(ConversationAITurnFailedEventModel), "aiTurnFailed")]
    [JsonDerivedType(typeof(ConversationHandedOffEventModel), "handedOff")]
    [JsonDerivedType(typeof(ConversationMessageEditedEventModel), "messageEdited")]
    [JsonDerivedType(typeof(ConversationMessageDeletedEventModel), "messageDeleted")]
    [JsonDerivedType(typeof(ConversationToolCallModel), "toolCall")]
    [JsonDerivedType(typeof(ConversationToolResultModel), "toolResult")]
    [MessagePack.Union(0, typeof(ConversationMessageModel))]
    [MessagePack.Union(1, typeof(ConversationJoinedEventModel))]
    [MessagePack.Union(2, typeof(ConversationAddedEventModel))]
    [MessagePack.Union(3, typeof(ConversationRemovedEventModel))]
    [MessagePack.Union(4, typeof(ConversationClosedEventModel))]
    [MessagePack.Union(5, typeof(ConversationReopenedEventModel))]
    [MessagePack.Union(6, typeof(ConversationAITurnFailedEventModel))]
    [MessagePack.Union(7, typeof(ConversationHandedOffEventModel))]
    [MessagePack.Union(8, typeof(ConversationMessageEditedEventModel))]
    [MessagePack.Union(9, typeof(ConversationMessageDeletedEventModel))]
    [MessagePack.Union(10, typeof(ConversationToolCallModel))]
    [MessagePack.Union(11, typeof(ConversationToolResultModel))]
    public abstract class ConversationEntryModel : IWebApiModel
    {
        /// <summary>
        /// The entry id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// The conversation id.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid ConversationId { get; init; }

        /// <summary>
        /// When the entry was stored (UTC).
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime Time { get; init; }

        /// <summary>
        /// Who wrote the entry or did what it records.
        /// </summary>
        [MessagePack.Key(3)]
        public ConversationReferenceModel Author { get; init; } = null!;

        /// <summary>
        /// Who may see the entry.
        /// </summary>
        [MessagePack.Key(4)]
        public ConversationVisibility Visibility { get; init; }
    }
}
