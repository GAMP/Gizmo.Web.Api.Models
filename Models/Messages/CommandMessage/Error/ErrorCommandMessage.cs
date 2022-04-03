namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Generic error command to be used for error responses.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ErrorCommandMessage  : CommandMessage
    {
        /// <summary>
        /// Gets error message.
        /// </summary>
        public string Message { get;init; }

        /// <summary>
        /// Gets optional error code.
        /// </summary>
        public int? ErrorCode { get;init;}
    }
}
