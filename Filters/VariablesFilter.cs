﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for variables.
    /// </summary>
    [Serializable]
    [DataContract]
    public class VariablesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
