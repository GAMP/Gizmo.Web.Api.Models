namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A station dropped while somebody was using it.
    /// </summary>
    /// <remarks>
    /// Raised from the session going pending rather than from the station's connection state, so it
    /// says something has interrupted a customer mid-session rather than merely that a machine is
    /// quiet. A station shutting down after its user logged out has no session to pend and raises
    /// nothing.
    /// <para>
    /// It closes when that session leaves pending, in either direction: the machine comes back and the
    /// session returns to active, or the pend times out and the session ends. So it always closes on
    /// its own, without an operator doing anything.
    /// </para>
    /// <para>
    /// Carries no span. The session has not ended, so there is nothing final to state, and how long it
    /// has been pending is the age of the entry.
    /// </para>
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterHostDisconnectedDetailsModel : ActionCenterEntryDetailsModel
    {
        /// <summary>
        /// The customer whose session was interrupted.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// The station to go and look at.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId { get; init; }
    }
}
