namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A customer session ended.
    /// </summary>
    /// <remarks>
    /// One kind for every station. Whether it was a console or a computer the manager reads from the
    /// host, so it can still word it differently and sound differently for the two without a second
    /// kind existing to say so.
    /// <para>
    /// Only what the manager cannot work out for itself. Whether the customer was a guest and what is
    /// still running on the station are live facts it resolves from its own services by id, and
    /// resolving them beats a snapshot that is stale by the time anyone looks. What is left is the
    /// pair of ids, the one fact that exists nowhere once the session is over, and the two reasons
    /// the server had for raising the ending as a task: what the customer owed and what they still
    /// held at that moment. Those are carried as measured, because the server decided on them and
    /// the manager's caches can predate the charges that closed the session; what they owe or hold
    /// now stays live on the manager.
    /// </para>
    /// <para>
    /// How the session ended is not here, and cannot be until the server records it: it knows the
    /// distinction internally but never persists or emits it, which needs the initiator written on
    /// the session change row. Until then a logout looks the same whoever ended it, and a session
    /// that merely timed out looks like one too.
    /// </para>
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterSessionEndedDetailsModel : ActionCenterEntryDetailsModel
    {
        /// <summary>
        /// The customer whose session ended.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// The station they were on.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId { get; init; }

        /// <summary>
        /// How long the session lasted, in seconds.
        /// </summary>
        [MessagePack.Key(2)]
        public double Span { get; init; }

        /// <summary>
        /// What the customer still owed when the session ended, as the server measured it then; zero
        /// when they owed nothing.
        /// </summary>
        /// <remarks>
        /// One of the two reasons an ending is a task rather than a notice. It says why the entry was
        /// raised; what they owe now is the manager's balance lookup.
        /// </remarks>
        [MessagePack.Key(3)]
        public decimal Outstanding { get; init; }

        /// <summary>
        /// How many assets the customer still had checked out when the session ended; zero when none.
        /// </summary>
        /// <remarks>
        /// The other reason. What is still out now is the manager's checked-out assets list.
        /// </remarks>
        [MessagePack.Key(4)]
        public int AssetsOut { get; init; }
    }
}
