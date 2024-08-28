using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application link.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationLinkModelUpdate : IApplicationLinkModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the application this link belongs to.
        /// </summary>
        [MessagePack.Key(1)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The caption of the link.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? Caption { get; set; }

        /// <summary>
        /// The description of the link.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string? Description { get; set; }

        /// <summary>
        /// The URL of the link.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(4)]
        public string? Url { get; set; }

        /// <summary>
        /// The display order of the link.
        /// </summary>
        [MessagePack.Key(5)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
