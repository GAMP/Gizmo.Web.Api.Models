using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// News update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class NewsUpdateModel : INewsModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id {get;init;}

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        [MaxLength(255)]
        public string Title { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Data { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public DateTime? StartDate { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public DateTime? EndDate { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        [MaxLength(255)]
        [Url()]
        public string? Url { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        [MaxLength(255)]
        [Url()]
        public string? MediaUrl { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        [MaxLength(255)]
        [Url()]
        public string? ThumbnailUrl { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)] 
        public bool IsCustomTemplate { get; init; }

    }
}
