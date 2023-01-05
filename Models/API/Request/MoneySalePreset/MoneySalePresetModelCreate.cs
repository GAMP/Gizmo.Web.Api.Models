﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [MessagePackObject]
    public sealed class MoneySalePresetModelCreate : IMoneySalePresetApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        [Range(0, double.MaxValue)] //TODO: double?
        [MessagePack.Key(0)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the money sale preset.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
