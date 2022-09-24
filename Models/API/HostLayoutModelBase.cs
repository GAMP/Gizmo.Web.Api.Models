using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayoutModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The id of the host.
        /// </summary>
        [Key(0)]
        public int HostId { get; set; }

        /// <summary>
        /// X Position.
        /// </summary>
        [Key(1)]
        public int X { get; set; }

        /// <summary>
        /// Y Position.
        /// </summary>
        [Key(2)]
        public int Y { get; set; }

        /// <summary>
        /// Display height.
        /// </summary>
        [Key(3)]
        public int Height { get; set; }

        /// <summary>
        /// Display width.
        /// </summary>
        [Key(4)]
        public int Width { get; set; }

        /// <summary>
        /// Indicates if hidden from layout.
        /// </summary>
        [Key(5)]
        public bool IsHidden { get; set; }

        #endregion
    }
}