using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application delete options.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationDeleteOptionsModel : IUriParametersQuery
    {
    }
}
