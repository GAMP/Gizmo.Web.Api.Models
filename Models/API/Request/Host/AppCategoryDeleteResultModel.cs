using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// App category delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class AppCategoryDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// App category delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public AppCategoryDeleteResult AppCategoryDeleteResult { get; init; }

        #endregion
    }
}
