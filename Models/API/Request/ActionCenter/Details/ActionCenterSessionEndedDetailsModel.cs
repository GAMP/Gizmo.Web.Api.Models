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
    /// Only what the manager cannot work out for itself. Whether the customer was a guest, what they
    /// owe, what is still running on the station and what equipment they still have out are all live
    /// facts it resolves from its own services by id, and resolving them beats a snapshot that is
    /// stale by the time anyone looks. What is left is the pair of ids and the one fact that exists
    /// nowhere once the session is over.
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
    }
}
