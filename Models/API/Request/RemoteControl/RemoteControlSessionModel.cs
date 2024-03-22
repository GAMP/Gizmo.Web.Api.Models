using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Remote control model.
    /// </summary>
    
    [Serializable, MessagePackObject]
    public sealed class RemoteControlSessionModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the remote control session.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Id { get; set; }

        /// <summary>
        /// The Access Key of the remote control session.
        /// </summary>
        [MessagePack.Key(1)]
        public string AccessKey { get; set; } = null!;
    }
}
