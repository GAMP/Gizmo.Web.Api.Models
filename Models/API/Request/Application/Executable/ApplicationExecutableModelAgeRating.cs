using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc />
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableModelAgeRating : IApplicationExecutableModelAgeRating
    {
        /// <inheritdoc />
        [Key(0)]
        public string ExecutablePath { get; set; } = string.Empty;

        /// <inheritdoc />
        [Key(1)]
        public int AgeRating { get; set; }
    }
}
