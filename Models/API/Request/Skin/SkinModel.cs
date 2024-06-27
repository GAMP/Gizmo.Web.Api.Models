using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Skin.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class SkinModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the skin.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; } = null!;

        #endregion
    }
}
