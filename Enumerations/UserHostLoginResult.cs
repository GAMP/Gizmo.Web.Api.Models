namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of the login of the current user on a host.
    /// </summary>
    public enum UserHostLoginResult
    {
        /// <summary>
        /// The user is logged in, the client entered the shell.
        /// </summary>
        Success = 0,

        /// <summary>
        /// No such host (unknown, deleted, empty guid) or the branch guid is not the branch of the host.
        /// </summary>
        HostNotFound = 1,

        /// <summary>
        /// The host is out of order or its client is not connected.
        /// </summary>
        HostUnavailable = 2,

        /// <summary>
        /// Another session is on the host.
        /// </summary>
        HostOccupied = 3,

        /// <summary>
        /// The user already has a session on another host.
        /// </summary>
        AlreadyLoggedIn = 4,

        /// <summary>
        /// A reservation the user is not in holds the host; repeat with its pin.
        /// </summary>
        PinRequired = 5,

        /// <summary>
        /// The pin sent does not open the reservation.
        /// </summary>
        PinInvalid = 6,

        /// <summary>
        /// The account is disabled.
        /// </summary>
        AccountDisabled = 7,

        /// <summary>
        /// No balance or time for this host.
        /// </summary>
        InsufficientBalance = 8,

        /// <summary>
        /// The login is restricted by age.
        /// </summary>
        RestrictedByAge = 9,

        /// <summary>
        /// The waiting line of the host group does not let the user in.
        /// </summary>
        NotInWaitingLine = 10,

        /// <summary>
        /// Not allowed for the user (group disallows manual login, user group and host group, host without host group).
        /// </summary>
        Denied = 11,

        /// <summary>
        /// Anything else, including a client that failed to execute the login.
        /// </summary>
        Failed = 12,

        /// <summary>
        /// Too many wrong pins in a row; a request with a pin is refused for a while.
        /// </summary>
        PinAttemptsExceeded = 13,
    }
}
