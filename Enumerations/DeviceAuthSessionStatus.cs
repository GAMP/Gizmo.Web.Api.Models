namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device activation session status.
    /// </summary>
    public enum DeviceAuthSessionStatus
    {
        /// <summary>
        /// Session is awaiting approval.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Session was approved and tokens were issued.
        /// </summary>
        Approved = 1,

        /// <summary>
        /// Session was denied by the approving user.
        /// </summary>
        Denied = 2,

        /// <summary>
        /// Session expired before approval.
        /// </summary>
        Expired = 3,
    }
}
