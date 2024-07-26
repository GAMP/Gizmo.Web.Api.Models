using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Application delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public ApplicationDeleteResult ApplicationDeleteResult { get; init; }

        #endregion
    }
}
