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
    public sealed class HostLayoutGroupModelUpdate : IHostLayoutGroupModel, IModelIntIdentifier, IUriParametersQuery
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

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int BranchId { get; set; }

        #endregion
    }
}
