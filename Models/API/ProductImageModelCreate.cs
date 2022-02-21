﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductImageModelCreate : ProductImageModelBase, IUrlQueryParameters
    {
    }
}