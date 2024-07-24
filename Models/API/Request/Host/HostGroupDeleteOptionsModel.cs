using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class HostGroupDeleteOptionsModel : IUriParametersQuery
    {
        /// <summary>
        /// The id of the host group to move hosts before delete.
        /// </summary>
        [MessagePack.Key(0)]
        public int? MoveToHostGroupId { get; init; }
    }
}
