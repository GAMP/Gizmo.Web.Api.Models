using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{ 
    /// <summary>
    /// Mapping model.
    /// </summary>
    public interface IMappingModel : IModelIntIdentifier , IWebApiModel
    {
        /// <summary>
        /// Mount point.
        /// </summary>
        string MountPoint { get; init; }

        /// <summary>
        /// Mapping source.
        /// </summary>
        string Source { get; init; }
    }
}
