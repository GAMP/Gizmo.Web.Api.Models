namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A customer started a session.
    /// </summary>
    /// <remarks>
    /// Raised from the session being created rather than from a session change, because a machine
    /// coming back from a drop also reports its session as active again and that is not a login.
    /// <para>
    /// A passive feed: nobody has to do anything about it, so it expires on its own.
    /// </para>
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ActionCenterUserLoggedInDetailsModel : ActionCenterEntryDetailsModel
    {
        /// <summary>
        /// The customer.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// The station they started on.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId { get; init; }

        /// <summary>
        /// The operator who logged them in; null when the customer did it themselves.
        /// </summary>
        /// <remarks>
        /// Carried rather than filtered on, since one message reaches the whole branch and the server
        /// cannot tailor it per recipient: the operator who performed the login suppresses their own
        /// copy, and colleagues see who did it. Null is a real answer here, unlike on a session ending,
        /// because there is no such thing as a login that happened by timing out.
        /// </remarks>
        [MessagePack.Key(2)]
        public int? OperatorId { get; init; }
    }
}
