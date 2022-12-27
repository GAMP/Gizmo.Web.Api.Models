using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.MoneySalePreset
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MoneySalePresetModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
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
