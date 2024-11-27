using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Api key model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApiKeyModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Api key name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Api key value.
        /// </summary>
        [MessagePack.Key(2)]
        public string ApiKey { get; init; } = null!;

        /// <summary>
        /// Api key type.
        /// </summary>
        [MessagePack.Key(3)]
        public ApiKeyType Type { get; init; }

        /// <summary>
        /// Api key expire time.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? ExpireTime { get; init; }

        /// <summary>
        /// Is deleted.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsDeleted { get; init; }

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsDisabled { get; init; }
    }
}
