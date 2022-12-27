using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Layout
{
    /// <summary>
    /// Host layout.
    /// </summary>
    [MessagePackObject]
    public sealed class HostLayout : IHostLayoutApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the host layout group this host layout belongs to.
        /// </summary>
        [Key(1)]
        public int HostLayoutGroupId { get; set; }

        /// <summary>
        /// The id of the host.
        /// </summary>
        [Key(2)]
        public int HostId { get; set; }

        /// <summary>
        /// X Position.
        /// </summary>
        [Key(3)]
        public int X { get; set; }

        /// <summary>
        /// Y Position.
        /// </summary>
        [Key(4)]
        public int Y { get; set; }

        /// <summary>
        /// Display height.
        /// </summary>
        [Key(5)]
        public int Height { get; set; }

        /// <summary>
        /// Display width.
        /// </summary>
        [Key(6)]
        public int Width { get; set; }

        /// <summary>
        /// Indicates if hidden from layout.
        /// </summary>
        [Key(7)]
        public bool IsHidden { get; set; }

        #endregion
    }
}