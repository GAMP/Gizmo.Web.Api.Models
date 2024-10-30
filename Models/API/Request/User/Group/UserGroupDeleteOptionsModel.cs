using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class UserGroupDeleteOptionsModel : IUriParametersQuery
    {
        /// <summary>
        /// The id of the user group to move users before delete.
        /// </summary>
        [MessagePack.Key(0)]
        public int? MoveToUserGroupId { get; init; }
    }
}
