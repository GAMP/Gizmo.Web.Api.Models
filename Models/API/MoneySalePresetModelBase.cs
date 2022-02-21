using MessagePack;
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
    [MessagePackObject]
    public class MoneySalePresetModelBase
    {
        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        [DataMember]
        [Required]
        [Range(0, double.MaxValue)]
        [MessagePack.Key(0)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the money sale preset.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }
    }
}
