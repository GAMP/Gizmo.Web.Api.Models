using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class HostGroupDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Host group delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public HostGroupDeleteResult HostGroupDeleteResult { get; init; }

        #endregion
    }
}
