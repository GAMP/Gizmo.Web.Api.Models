using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset with time.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TimeSalePresetWithTimeModelBase : TimeSalePreset
    {
        /// <summary>
        /// The value of the time sale preset with time.
        /// </summary>
        [DataMember]
        [Required]
        public int Value { get; set; }

    }
}
