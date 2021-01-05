using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TimeSalePreset
    {
        #region PROPERTIES

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
