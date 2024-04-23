using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Waiting line entry filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineEntryFilterModel : IModelFilter<WaitingLineEntryModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Host group id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? UserId
        {
            get; init;
        }

        /// <summary>
        /// Entry state.
        /// </summary>
        [MessagePack.Key(4)]
        public WaitingLineState? State
        {
            get; init;
        }
    }
}
