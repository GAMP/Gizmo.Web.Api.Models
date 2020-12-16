using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset with money.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TimeSalePresetWithMoneyModelBase : TimeSalePreset
    {
        /// <summary>
        /// The value of the time sale preset with money.
        /// </summary>
        [DataMember]
        [Required]
        public decimal Value { get; set; }

    }
}
