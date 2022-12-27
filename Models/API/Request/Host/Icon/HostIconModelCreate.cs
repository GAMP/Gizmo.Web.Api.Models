using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Icon
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [MessagePackObject]
    public sealed class HostIconModelCreate : IHostIconApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}
