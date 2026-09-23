namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A station is not enforcing its security while somebody is using it.
    /// </summary>
    /// <remarks>
    /// Unlike every other kind, this describes a condition rather than a moment, so it does not expire:
    /// it lasts exactly as long as the condition, and closes when the station reports security back on.
    /// An unsecured station with nobody on it raises nothing, since there is no one to take advantage
    /// of it.
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
    }
}
