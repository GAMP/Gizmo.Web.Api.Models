﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user agreements.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserAgreementsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return enabled user agreements.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public bool? IsEnabled { get; set; }
    }
}