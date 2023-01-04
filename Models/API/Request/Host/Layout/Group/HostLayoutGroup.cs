#nullable enable

using Gizmo.Web.Api.Models;
using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [MessagePackObject]
    public sealed class HostLayoutGroup : IHostLayoutGroupApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The host layouts of the host layout group.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<HostLayout>? HostLayouts { get; set; }

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the layout group.
        /// </summary>
        [MessagePack.Key(3)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}