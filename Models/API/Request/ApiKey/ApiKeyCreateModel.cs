using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Api key create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApiKeyCreateModel : IWebApiModel
    {
        /// <summary>
        /// Api key name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Api key type.
        /// </summary>
        [MessagePack.Key(1)]
        public ApiKeyType Type { get; set; }

        /// <summary>
        /// Optional api key expiration.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? ExpireTime { get; set; }
    }
}
