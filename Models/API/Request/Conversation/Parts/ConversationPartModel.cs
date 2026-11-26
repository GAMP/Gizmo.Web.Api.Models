using System.Text.Json.Serialization;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One part of a message's content.
    /// </summary>
    /// <remarks>
    /// Today only text; attachments come later as another part type. In JSON the <c>type</c> discriminator comes first.
    /// </remarks>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(ConversationTextPartModel), "text")]
    [MessagePack.Union(0, typeof(ConversationTextPartModel))]
    public abstract class ConversationPartModel : IWebApiModel
    {
    }
}
