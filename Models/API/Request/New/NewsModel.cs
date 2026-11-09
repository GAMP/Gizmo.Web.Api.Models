using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class NewsModel : INewsModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [Key(1)]
        public bool IsCustomTemplate { get; init; }

        /// <inheritdoc/>
        [Key(2)]
        public string Title { get; init; } = string.Empty;

        /// <inheritdoc/>
        [Key(3)]
        public string? Data { get; init; } = null!;

        /// <inheritdoc/>
        [Key(4)]
        public DateTime? StartDate { get; init; }

        /// <inheritdoc/>
        [Key(5)]
        public DateTime? EndDate { get; init; }

        /// <inheritdoc/>
        [Key(6)]
        public string? Url { get; init; }

        /// <inheritdoc/>
        [Key(7)]
        public string? MediaUrl { get; init; }

        /// <inheritdoc/>
        [Key(8)]
        public string? ThumbnailUrl { get; init; }

        /// <summary>
        /// Whether the news is enabled in every active branch.
        /// </summary>
        /// <remarks>
        /// Filled only by the user API (api/user/v3/news); false otherwise.
        /// </remarks>
        [Key(9)]
        public bool IsAllBranches { get; init; }

        /// <summary>
        /// Names of the active branches the news is enabled in, ordered by name; empty when <see cref="IsAllBranches"/> is true.
        /// </summary>
        /// <remarks>
        /// Filled only by the user API (api/user/v3/news); null otherwise.
        /// </remarks>
        [Key(10)]
        public IEnumerable<string>? BranchNames { get; init; }
    }
}
