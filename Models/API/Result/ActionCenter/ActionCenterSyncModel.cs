using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Everything one operator needs to rebuild their action center in a single call.
    /// </summary>
    /// <remarks>
    /// Answered for the caller, which is what lets it carry per operator state that an entry
    /// broadcast to a group never can. A manager asks for this on connect and on every reconnect,
    /// replaces its whole local set with the result, and then trusts the event stream again.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterSyncModel : IWebApiModel
    {
        /// <summary>
        /// The highest sequence this answer accounts for.
        /// </summary>
        /// <remarks>
        /// This is the manager's high water mark for the connection it syncs on, replacing whatever
        /// it held before. An event message at or below it is already included here and is dropped,
        /// which is what makes the sync and the live stream safe to overlap. There is no run
        /// identifier because a sequence is never compared across runs: a restart drops the
        /// connection, and a reconnect re-syncs before any message is processed.
        /// </remarks>
        [MessagePack.Key(0)]
        public long Sequence { get; init; }

        /// <summary>
        /// The open entries addressed to the caller, oldest first.
        /// </summary>
        /// <remarks>
        /// Open only. An entry that resolved or expired while the manager was away is simply absent,
        /// which tells it the same thing a status change would have.
        /// </remarks>
        [MessagePack.Key(1)]
        public IEnumerable<ActionCenterEntryModel> Entries { get; init; } = Enumerable.Empty<ActionCenterEntryModel>();

        /// <summary>
        /// Of those entries, the ones the caller has already seen.
        /// </summary>
        /// <remarks>
        /// Sent as a set of ids rather than a flag on each entry, so that the entry stays one shared
        /// object that reads the same for everybody. A manager holds this alongside the entries and
        /// keeps it current from the view changed event message.
        /// </remarks>
        [MessagePack.Key(2)]
        public IEnumerable<Guid> ReadEntryIds { get; init; } = Enumerable.Empty<Guid>();

        /// <summary>
        /// Of those entries, the ones the caller has hidden.
        /// </summary>
        /// <remarks>
        /// Empty unless dismissed entries were asked for, since they are left out of
        /// <see cref="Entries"/> by default. Present so a recently dismissed view can tell the two
        /// apart in the one answer.
        /// </remarks>
        [MessagePack.Key(3)]
        public IEnumerable<Guid> DismissedEntryIds { get; init; } = Enumerable.Empty<Guid>();
    }
}
