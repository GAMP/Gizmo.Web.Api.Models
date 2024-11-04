using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Feed creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FeedCreateModel : IFeedModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        [Required()]
        public string Title { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int Maximum { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        [Required]
        [Url()]
        public string Url { get; init; } = string.Empty;
    }
}
