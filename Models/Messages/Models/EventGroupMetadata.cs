#nullable enable

using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Messaging.Models
{
    /// <summary>
    /// Event group metadata.
    /// </summary>
    public sealed class EventGroupMetadata
    {
        #region PROPERTIES

        /// <summary>
        /// Event group name.
        /// </summary>
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Event group description.
        /// </summary>
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Object type.
        /// </summary>
        public string Type { get;init;} =string.Empty;

        /// <summary>
        /// Events.
        /// </summary>
        public IEnumerable<EventMetadata> Events { get; init; } = Enumerable.Empty<EventMetadata>();

        #endregion
    }
}
