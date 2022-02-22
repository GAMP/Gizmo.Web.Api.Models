﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user notes.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserNotesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
