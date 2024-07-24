using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class HostDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Host delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public HostDeleteResult HostDeleteResult { get; init; }

        #endregion
    }
}
