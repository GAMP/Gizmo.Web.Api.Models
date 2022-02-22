﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application licenses.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationLicensesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return licenses with names that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public string LicenseName { get; set; }
    }
}
