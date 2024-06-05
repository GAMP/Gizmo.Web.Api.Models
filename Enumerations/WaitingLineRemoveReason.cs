namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Waiting line user removal reason.
    /// </summary>
    public enum WaitingLineRemoveReason
    {
        /// <summary>
        /// Waiting line was processed.
        /// </summary>
        Processed = 0,
        /// <summary>
        /// Cancelled by operator.
        /// </summary>
        Cancelled = 1,
        /// <summary>
        /// Timed out.
        /// </summary>
        TimedOut = 2,
    }
}
