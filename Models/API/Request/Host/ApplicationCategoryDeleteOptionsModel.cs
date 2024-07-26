using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationCategoryDeleteOptionsModel : IUriParametersQuery
    {
        /// <summary>
        /// The id of the application category to move applications before delete.
        /// </summary>
        [MessagePack.Key(0)]
        public int? MoveToApplicationCategoryId { get; init; }
    }
}
