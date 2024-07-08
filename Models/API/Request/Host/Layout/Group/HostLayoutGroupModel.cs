using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostLayoutGroupModel : IHostLayoutGroupModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The host layouts of the host layout group.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<HostLayoutModel> HostLayouts { get; set; } = Enumerable.Empty<HostLayoutModel>();

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int BranchId { get; set; }

        #endregion
    }
}
