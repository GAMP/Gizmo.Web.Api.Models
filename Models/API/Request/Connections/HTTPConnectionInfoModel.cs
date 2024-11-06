namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Http connection info model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public abstract class HTTPConnectionInfoModel
    {
        /// <summary>
        /// Connection id.
        /// </summary>
        [MessagePack.Key(0)]
        public string? ConnectionId
        {
            get; init;
        }

        /// <summary>
        /// Remote ip address.
        /// </summary>
        [MessagePack.Key(1)]
        public string? RemoteIpAddress
        {
            get; init;
        }

        /// <summary>
        /// Local ip address.
        /// </summary>
        [MessagePack.Key(2)]
        public string? LocalIpAddress
        {
            get; init;
        }

        /// <summary>
        /// Remote port.
        /// </summary>
        [MessagePack.Key(3)]
        public int RemotePort
        {
            get; init;
        }

        /// <summary>
        /// Local port.
        /// </summary>
        [MessagePack.Key(4)]
        public int LocalPort
        {
            get; init;
        }
    }
}
