using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Process filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemProcessFilterModel : IWebApiModel, IUriParametersQuery
    {
        /// <summary>
        /// Optional process name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? ProcessName { get; init; }
    }
}
