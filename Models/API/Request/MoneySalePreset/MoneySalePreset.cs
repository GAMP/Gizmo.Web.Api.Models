﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [MessagePackObject]
    public sealed class MoneySalePreset : IMoneySalePresetApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        [Range(0, double.MaxValue)]
        [MessagePack.Key(1)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the money sale preset.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
