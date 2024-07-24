using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// App category delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class AppCategoryDeleteOptionsModel : IUriParametersQuery
    {
        /// <summary>
        /// The id of the app category to move apps before delete.
        /// </summary>
        [MessagePack.Key(0)]
        public int? MoveToAppCategoryId { get; init; }
    }
}
