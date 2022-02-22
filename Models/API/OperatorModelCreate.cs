﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class OperatorModelCreate : OperatorModelBase, IUrlQueryParameters
    {
        /// <summary>
        /// The initial password for the operator, if left empty no password will be set.
        /// </summary>
        [DataMember]
        [StringLength(24)]
        [MessagePack.Key(100)]
        public string Password { get; set; }
    }
}
