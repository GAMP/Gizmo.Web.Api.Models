﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Attribute.
    /// </summary>
    [MessagePackObject]
    public sealed class AttributeModelUpdate : IAttributeApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The friendly name of the attribute.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string FriendlyName { get; set; } = null!;

        #endregion
    }
}