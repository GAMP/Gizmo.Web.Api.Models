using Gizmo;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostGroup : EntityBase
    {
        /// <summary>
        /// The name of the host group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the skin this host group uses by default.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string SkinName { get; set; }

        [DataMember]
        public HostGroupOptionType Options { get; set; }

        /// <summary>
        /// The Id of the application profile this host group is associated with.
        /// </summary>
        [DataMember]
        public int? AppGroupId { get; set; }

        /// <summary>
        /// The Id of the security profile this host group is associated with.
        /// </summary>
        [DataMember]
        public int? SecurityProfileId { get; set; }

        /// <summary>
        /// The Id of the guest group this host group uses by default.
        /// </summary>
        [DataMember]
        public int? DefaultGuestGroupId { get; set; }
    }
}