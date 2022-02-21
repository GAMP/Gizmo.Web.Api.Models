using MessagePack;
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
    [MessagePackObject]
    public class TimeSalePresetModelBase
    {
        /// <summary>
        /// The value of the time sale preset.
        /// </summary>
        [DataMember]
        [Required]
        [Range(0, int.MaxValue)]
        [MessagePack.Key(0)]
        public int Value { get; set; }

        /// <summary>
        /// The display order of the time sale preset.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

    }
}