using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group layout host parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutGroupLayoutModel : IUriParametersQuery
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Height { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int Width { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int X { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int Y { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public bool IsHidden { get; set; }
    }
}
