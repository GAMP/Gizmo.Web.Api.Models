using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Remote control session connect result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class RemoteControlSessionConnectResultModel
    {
        /// <summary>
        /// Start result.
        /// </summary>
        [MessagePack.Key(0)]
        public RemoteControlSessionConnectResultCode Result { get; init; }

        /// <summary>
        /// Remote control client (agent) process id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ProcessId
        {
            get; init;
        }
    }    
}
