using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line fixed time.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class LineFixedTime : IUrlQueryParameters
    {
        /// <summary>
        /// The quantity type of the fixed time line.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public FixedTimeQuantityType QuantityType { get; set; }
    }
}