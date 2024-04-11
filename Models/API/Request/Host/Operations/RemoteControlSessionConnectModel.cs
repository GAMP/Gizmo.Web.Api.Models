namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Remote session connection parameters.
    /// </summary>
    /// <remarks>
    /// This parameters are sent to client and used to connect to a remote session on specified server.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class RemoteControlSessionConnectModel
    {
        /// <summary>
        /// Gets remote session server URL.
        /// </summary>
        [MessagePack.Key(0)]
        public string ServerUrl
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Gets remote session id.
        /// </summary>
        [MessagePack.Key(1)]
        public string SessionId
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Gets remote session password.
        /// </summary>
        [MessagePack.Key(2)]
        public string Password
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Additional arguments.
        /// </summary>
        [MessagePack.Key(3)]
        public string? AdditionalArguments
        {
            get; init;
        }
    }
}
