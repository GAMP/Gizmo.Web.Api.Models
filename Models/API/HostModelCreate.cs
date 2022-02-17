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
    public class HostModelCreate : HostModelBase, IUrlQueryParameters
    {
        /// <summary>
        /// The type of the host.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValue]
        public HostType HostType { get; set; }
    }
}