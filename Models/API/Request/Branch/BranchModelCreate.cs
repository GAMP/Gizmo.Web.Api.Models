using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchModelCreate : IBranchModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = string.Empty;
    }
}
