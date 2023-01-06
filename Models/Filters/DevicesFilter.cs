#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for devices.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DevicesFilter : IFilterApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public PaginationFilter PaginationFilter { get; set; } = new();

        /// <summary>
        /// Return devices of the specified device type.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public DeviceType? DeviceType { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(2)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
