using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationCategoryDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Application category delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public ApplicationCategoryDeleteResult ApplicationCategoryDeleteResult { get; init; }

        #endregion
    }
}
