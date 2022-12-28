using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.TimeSale
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [MessagePackObject]
    public sealed class TimeSalePresetModelCreate : ITimeSalePresetApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        [MessagePack.Key(0)]
        [Range(0, int.MaxValue)]
        public int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
