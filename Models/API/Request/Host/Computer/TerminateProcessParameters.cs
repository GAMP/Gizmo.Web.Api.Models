using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Process termination parameters.
    /// </summary>
    public sealed class TerminateProcessParameters : IWebApiModel, IUriParametersQuery
    {
        /// <summary>
        /// Recursive tree termination.
        /// </summary>
        public bool Tree { get; init; }
    }
}
