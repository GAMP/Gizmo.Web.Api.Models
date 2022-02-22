﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for time sale presets.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class TimeSalePresetsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
