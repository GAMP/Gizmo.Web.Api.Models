using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User session filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserSessionFilter : IModelFilter<UserSessionModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public DateTime? DateTo { get; set; }

        /// <inheritdoc/>
        [MessagePack. Key(3)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Specific user id filter.
        /// </summary>
        [MessagePack.Key(4)]
        public int? UserId
        {
            get;init;
        }

        /// <summary>
        /// Specific host id filter.
        /// </summary>
        [MessagePack.Key(5)]
        public int? HostId
        {
            get;init;
        }

        /// <summary>
        /// Specific session state.
        /// </summary>
        [MessagePack.Key(6)]
        public UserSessionState? State
        {
            get;init;
        }
    }
}
