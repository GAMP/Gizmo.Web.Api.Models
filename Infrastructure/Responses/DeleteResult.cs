﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Delete result.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class DeleteResult
    { }
}