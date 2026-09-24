namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// The operator facing kind of an action center entry.
    /// </summary>
    /// <remarks>
    /// This is the key an operator configures a sound against, and it is also the details union key,
    /// so each kind has exactly one details type and the two can never disagree.
    /// <para>
    /// Deliberately small, and measured against what the v2 Manager actually made a sound for, since
    /// that set had been through real use. A host coming back was dropped because its whole job was
    /// to close the disconnect entry, and an autonomous login because a session row cannot yet say
    /// whether a person or a timeout produced it. Neither had a v2 counterpart.
    /// </para>
    /// </remarks>
    public enum ActionCenterEntryKind
    {
        /// <summary>
        /// A customer session ended.
        /// </summary>
        /// <remarks>
        /// One kind for every station, console or computer. Which it was, the manager reads from the
        /// host, so it can still say and sound different things for the two without this having to
        /// split. A sound kind may be finer grained than an entry kind for exactly that reason.
        /// <para>
        /// One kind whether or not the customer left owing money, too. That is not a different event,
        /// it is the same event needing chasing, which the server says by giving the entry no expiry.
        /// The manager reads that rather than deciding from a balance of its own, so the sound is right
        /// the first time even when its cached balance still predates the session's final charges.
        /// </para>
        /// </remarks>
        SessionEnded = 0,

        /// <summary>
        /// A customer placed an order.
        /// </summary>
        OrderReceived = 1,

        /// <summary>
        /// A customer asked for assistance.
        /// </summary>
        AssistanceRequested = 2,

        /// <summary>
        /// A host is not enforcing its security while somebody is using it.
        /// </summary>
        /// <remarks>
        /// A condition rather than a moment: it lasts until security comes back, and unlike every
        /// other kind here it is raised only while a session is open on that host.
        /// </remarks>
        HostSecurityDisabled = 3,

        /// <summary>
        /// A station dropped while somebody was using it.
        /// </summary>
        /// <remarks>
        /// Not any disconnect. The trigger is the session going pending, so a station shutting down
        /// after its user has already logged out raises nothing, which is what keeps this from being
        /// the noisiest kind in a busy venue. Carried over from the v2 client disconnect sound, which
        /// fired on the same condition.
        /// </remarks>
        HostDisconnected = 4,

        /// <summary>
        /// A customer started a session.
        /// </summary>
        /// <remarks>
        /// Every login, not only self-service ones. Who started it travels with the entry instead of
        /// being filtered out here, so the operator who performed it can suppress their own while
        /// colleagues still see it.
        /// </remarks>
        UserLoggedIn = 5,
    }
}
