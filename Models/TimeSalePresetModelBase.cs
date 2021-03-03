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
    public class TimeSalePresetModelBase
    {
        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        [DataMember]
        [Required]
        [Range(0, int.MaxValue)]
        public int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

    }
}