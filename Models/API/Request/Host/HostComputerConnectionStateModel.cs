namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host connection model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostComputerConnectionStateModel : IWebApiModel
    {
        /// <summary>
        /// Host computer id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Indicates that host is connected.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsConnected { get;init;}

        /// <summary>
        /// Connection IP Address.
        /// </summary>
        /// <remarks>Null in case of disconnected host.</remarks>
        [MessagePack.Key(2)]
        public string? IPAddress { get;init;}
    }
}
