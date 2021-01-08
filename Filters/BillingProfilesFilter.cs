
﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for billing profiles.
    /// </summary>
    [Serializable]
    [DataContract]
    public class BillingProfilesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
