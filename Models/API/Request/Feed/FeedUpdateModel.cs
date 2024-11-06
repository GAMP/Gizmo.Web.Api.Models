using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Feed creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FeedUpdateModel : IFeedModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        [Required]
        public string Title { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int Maximum { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        [Url()]
        [Required]
        public string Url { get; init; } = string.Empty;
    }
}
