using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group delete result.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroupDeleteResultModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Product group delete result.
        /// </summary>
        [MessagePack.Key(0)]
        public ProductGroupDeleteResult ProductGroupDeleteResult { get; init; }

        #endregion
    }
}
