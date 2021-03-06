﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for host icons.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostIconsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
