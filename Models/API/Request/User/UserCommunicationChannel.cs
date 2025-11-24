using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User communication channel.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserCommunicationChannel : IWebApiModel
    {
        /// <summary>
        /// Channel type.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Type { get; init; }

        /// <summary>
        /// Channel value.
        /// </summary>
        [MessagePack.Key(1)]
        public string Value { get; set; } = null!;

        /// <summary>
        /// Indicates that channel is verified.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsVerified { get; set; }
    }
}
