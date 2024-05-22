using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group layout host parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutCreateUpdateModel : IUriParametersQuery
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

        /// <summary>
        /// Host grid layout row.
        /// </summary>
        [MessagePack.Key(4)]
        public int Row { get; set; }

        /// <summary>
        /// Host grid layout column.
        /// </summary>
        [MessagePack.Key(5)]
        public int Column { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public bool IsHidden { get; set; }
    }
}
