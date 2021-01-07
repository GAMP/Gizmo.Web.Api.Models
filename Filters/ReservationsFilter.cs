
﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for reservations.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ReservationsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
