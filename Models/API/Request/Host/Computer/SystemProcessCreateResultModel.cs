namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Process creation result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemProcessCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Created process id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProcessId { get; init; }

        /// <summary>
        /// Exit code.
        /// </summary>
        /// <remarks>
        /// This will only have value if we use <see cref="SystemProcessCreateModel.WaitForTermination"/> flag and wait have not expired.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? ExitCode { get; init; }
    }
}
