using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.MoneySalePreset
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MoneySalePresetModelUpdate : MoneySalePresetModelBase, IApiModelIdentifier
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