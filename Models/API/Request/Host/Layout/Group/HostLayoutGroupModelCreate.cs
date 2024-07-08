using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class HostLayoutGroupModelCreate : IHostLayoutGroupModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int BranchId { get; set; }

        #endregion
    }
}
