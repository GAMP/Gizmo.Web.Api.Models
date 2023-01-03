﻿#nullable enable

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Online payments configuration model.
    /// </summary>
    [MessagePackObject]
    public sealed class OnlinePaymentsConfiguration
    {
        #region PROPERTIES

        /// <summary>
        /// The preset amounts.
        /// </summary>
        [Key(0)]
        public List<decimal> Presets { get; set; } = new();

        /// <summary>
        /// Indicates whether the user can set custom value.
        /// </summary>
        [Key(1)]
        public bool AllowCustomValue { get; set; }

        /// <summary>
        /// The minimum allowed amount.
        /// </summary>
        [Key(2)]
        public decimal MinimumAmount { get; set; }

        #endregion
    }
}