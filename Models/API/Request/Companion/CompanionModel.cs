using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Companion model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CompanionModel : ICompanionModel
    {
        /// <summary>
        /// Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Guid.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid Guid { get; set; }
    }
}
