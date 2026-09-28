namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A station stopped enforcing its security while somebody was using it.
    /// </summary>
    /// <remarks>
    /// A moment rather than a condition: it says security was turned off under a running session, and
    /// nothing about whether it is still off by the time anybody reads it, so it expires like any other
    /// notice. An unsecured station with nobody on it raises nothing, since there is no one to take
    /// advantage of it.
    /// <para>
    /// The station is the subject, so the station is all it carries. Who is using it is left to the
    /// manager's host active user lookup, for two reasons: a user here would only be whoever happens
    /// to be sitting there rather than the subject of the entry, and a host can have several users at
    /// once, which a single field could not represent without picking one arbitrarily. The lookup also
    /// answers the question an operator walking over actually has, who is there now. Who was there
    /// at the moment security dropped belongs to the session history in the database.
    /// </para>
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterHostSecurityDisabledDetailsModel : ActionCenterEntryDetailsModel
    {
        /// <summary>
        /// The station.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// The operator who turned security off; null when the station reported it on its own.
        /// </summary>
        /// <remarks>
        /// Carried rather than filtered on, for the reason a login carries its operator: one message
        /// reaches the whole branch and the server cannot tailor it per recipient, so the operator who
        /// did it suppresses their own copy. Read from the request that made the change, since the
        /// property itself records nobody.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? OperatorId { get; init; }
    }
}
