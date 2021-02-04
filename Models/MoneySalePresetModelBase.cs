using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [DataContract]
    [Serializable]
    public class MoneySalePresetModelBase
    {
        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        [DataMember]
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the money sale preset.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }
    }
}
