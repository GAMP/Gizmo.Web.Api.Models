#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host endpoint.
    /// </summary>
    [MessagePackObject]
    public sealed class HostModelEndpoint
    {
        #region PROPERTIES

        /// <summary>
        /// The maximum number of users the endpoint can host.
        /// </summary>
        [Key(0)]
        public int MaximumUsers { get; set; }

        #endregion
    }
}
