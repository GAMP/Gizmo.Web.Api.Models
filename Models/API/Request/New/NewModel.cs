using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class NewModel : INewModel
    {
        /// <inheritdoc/>
        [Key(0)]
        public string Title { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public string Data { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public DateTime? StartDate { get; init; }

        /// <inheritdoc/>
        [Key(3)]
        public DateTime? EndDate { get; init; }

        /// <inheritdoc/>
        [Key(4)]
        public string Url { get; init; }

        /// <inheritdoc/>
        [Key(5)]
        public string MediaUrl { get; init; }

        /// <inheritdoc/>
        [Key(6)]
        public int Id { get; init; }
    }
}
