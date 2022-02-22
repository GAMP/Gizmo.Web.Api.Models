using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class HostModelCreate : HostModelBase, IUrlQueryParameters
    {
        /// <summary>
        /// The type of the host.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValue]
        [MessagePack.Key(100)]
        public HostType HostType { get; set; }
    }
}