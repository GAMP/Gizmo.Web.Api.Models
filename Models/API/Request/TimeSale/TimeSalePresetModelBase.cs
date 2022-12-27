using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.TimeSale
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeSalePresetModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        [Required]
        [Range(0, int.MaxValue)]
        [MessagePack.Key(0)]
        public int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion

    }
}