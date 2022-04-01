﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class TimeProductDisallowedHostGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host group.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Whether this host group is disallowed for this time product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}