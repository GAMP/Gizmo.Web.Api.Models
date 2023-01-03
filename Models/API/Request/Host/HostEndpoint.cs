#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host
{
    /// <summary>
    /// Host endpoint.
    /// </summary>
    [MessagePackObject]
    public sealed class HostEndpoint
    {
        #region PROPERTIES

        /// <summary>
        /// The maximum number of users the endpoint can host.
        /// </summary>
        [MessagePack.Key(0)]
        public int MaximumUsers { get; set; }

        #endregion
    }
}
