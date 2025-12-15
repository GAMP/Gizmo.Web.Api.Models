namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization task result status.
    /// </summary>
    public enum FiscalizationTaskResultStatus
    {
        /// <summary>
        /// Success.
        /// </summary>
        Queued = 0,

        /// <summary>
        /// Already printed.
        /// </summary>
        AlreadyPrinted = 1,

        /// <summary>
        /// Already pending.
        /// </summary>
        AlreadyPending = 2,       
    }
}
