using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class HostDeleteOptionsModel : IUriParametersQuery
    {
    }
}
