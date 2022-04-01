﻿using MessagePack;
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
    [MessagePackObject]
    public class HostGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the skin this host group uses by default.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string SkinName { get; set; }

        /// <summary>
        /// The Id of the application profile this host group is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public int? ApplicationGroupId { get; set; }

        /// <summary>
        /// The Id of the security profile this host group is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public int? SecurityProfileId { get; set; }

        /// <summary>
        /// The Id of the guest group this host group uses by default.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public int? DefaultGuestGroupId { get; set; }

        #endregion
    }
}