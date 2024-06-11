using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc />
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableAgeRatingModel : IApplicationExecutableAgeRatingModel
    {
        /// <inheritdoc />
        [Key(0)]
        [Sortable]
        public string ExecutablePath { get; set; } = string.Empty;

        /// <inheritdoc />
        [Key(1)]
        [Sortable]
        public int AgeRating { get; set; }
    }
}
