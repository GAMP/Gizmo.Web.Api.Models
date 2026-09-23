using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One thing an operator may need to know about or act on.
    /// </summary>
    /// <remarks>
    /// The entry is the unit, not the domain event behind it: one entry per subject, fixed from the
    /// moment it opens until it closes. It carries ids rather than the things they resolve to, so a
    /// manager renders it from its own lookups, which also keeps it current as the subject changes. It
    /// carries no text and no presentation, which the manager derives from the details kind and the
    /// flags.
    /// <para>
    /// An entry on the wire is always open. There is no status here because a manager never holds a
    /// closed one: a connected manager is told it closed by the status change message and drops it,
    /// and one that re-syncs simply does not receive it. How it closed, and who closed it, travel on
    /// that status change message and nowhere else.
    /// </para>
    /// <para>
    /// Everything here is shared: it means the same thing to every operator the entry reaches.
    /// What one operator has read or hidden is theirs alone, and deliberately absent, because an
    /// entry sent to a branch group has many recipients and the server cannot flatten a set of
    /// operator ids into one truthful flag for all of them. That state travels on
    /// <see cref="ActionCenterSyncModel"/> for the caller who asks, and on the view changed event
    /// message for the operator it belongs to.
    /// </para>
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterEntryModel : IWebApiModel
    {
        /// <summary>
        /// Identity, and the subject of the read, dismiss and resolve calls.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <summary>
        /// The order this entry was created in, relative to every other entry in the store.
        /// </summary>
        /// <remarks>
        /// Not an identifier: one store-wide counter, assigned when the entry is created and fixed for
        /// life. It exists to reconcile the sync snapshot with the live stream. A manager joins its groups
        /// before syncing, so a created message can arrive while the snapshot is in flight; one at or below
        /// the snapshot's high water mark is already in it and is dropped, which is what stops the same
        /// entry being announced twice. Nothing else needs it: an entry's facts never change once it is
        /// open, and closing or hiding one is idempotent. Only meaningful within one connection, since the
        /// counter restarts with the process and a restart always forces a re-sync.
        /// </remarks>
        [MessagePack.Key(1)]
        public long Sequence { get; init; }

        /// <summary>
        /// What kind of audience the entry is addressed to.
        /// </summary>
        /// <remarks>
        /// Domain state rather than routing: the server has already delivered the entry to the right
        /// group by the time the manager reads this. The manager needs it because an entry addressed to
        /// one operator resolves when dismissed instead of merely hiding, since nobody else can see it
        /// and hiding it would lose the task, and because "for you" and "for the desk" are presented
        /// differently. Neither can be worked out from anything else on the entry.
        /// </remarks>
        [MessagePack.Key(2)]
        public ActionCenterScopeType ScopeType { get; init; }

        /// <summary>
        /// Which branch, register or operator the entry is addressed to; null when the scope is global.
        /// </summary>
        /// <remarks>
        /// Usually the reader's own branch, register or self. It tells an operator something new only
        /// when they work across several branches and want to see or group by which one an entry is
        /// for.
        /// </remarks>
        [MessagePack.Key(3)]
        public int? ScopeId { get; init; }

        /// <summary>
        /// UTC time at which the server will expire this entry, or null when it never does and leaves
        /// only once something closes it.
        /// </summary>
        /// <remarks>
        /// The server's clock and the server's decision, like <see cref="CreatedTime"/>: it is that time
        /// plus the kind's lifetime, and the sweep that expires the entry compares against the same
        /// clock. A manager converts it for display exactly as it does every other API time.
        /// <para>
        /// Carried rather than derived from the kind, because it is not a property of the kind: how
        /// long a kind stays is configurable, so whether and when a given entry expires is decided on
        /// the server at the moment it is raised. A manager holding its own table of which kinds expire
        /// would drift the first time somebody changed one. Null is the deliberate indicator that it
        /// persists, so one field says both whether and when.
        /// </para>
        /// <para>
        /// For rendering, never for removal. A manager may show a countdown or fade from it, and one
        /// that has just synced can tell a notice about to vanish from one freshly raised. But the
        /// expired message is the only thing that takes an entry away, so that every manager drops it at
        /// the one moment the server decides rather than each by its own drifting clock.
        /// </para>
        /// <para>
        /// It says nothing about presentation. Whether an entry reads as a task or a notice comes from
        /// the kind, and the two do not line up: a station running without security is a notice that
        /// nonetheless persists until security returns.
        /// </para>
        /// </remarks>
        [MessagePack.Key(4)]
        public DateTime? ExpiresTime { get; init; }

        /// <summary>
        /// UTC time the thing happened, taken from the source rather than from processing time.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// Everything about the entry that is not its lifecycle, and which kind of entry this is.
        /// </summary>
        /// <remarks>
        /// Always present. The concrete type is the kind, so there is no separate kind field to
        /// disagree with it; a consumer that needs the kind matches on the type. A kind that adds
        /// nothing still has its own empty details type.
        /// <para>
        /// What the entry points at lives here too, rather than as a set of nullable ids on the
        /// envelope, so each kind names only the things it actually refers to. If a generic
        /// question ever needs asking across kinds, such as whether any entry concerns a given
        /// host, that belongs as a member on this base rather than as a field every entry carries.
        /// </para>
        /// </remarks>
        [MessagePack.Key(6)]
        public required ActionCenterEntryDetailsModel Details { get; init; }
    }
}
