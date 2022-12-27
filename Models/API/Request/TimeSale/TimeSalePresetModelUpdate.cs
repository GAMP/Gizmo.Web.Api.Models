using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.TimeSale
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeSalePresetModelUpdate : TimeSalePresetModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        #endregion
    }
}