using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Remote control session creation model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class RemoteControlSessionCreateModel : IWebApiModel
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

        /// <summary>
        /// Desktop url.
        /// </summary>
        [MessagePack.Key(2)]
        public string DesktopUrl { get; set; } = null!;

        /// <summary>
        /// Optional viewer URL.
        /// </summary>
        [MessagePack.Key(3)]
        public string? ViewerUrl
        {
            get; init;
        } = null!;
    }
}
