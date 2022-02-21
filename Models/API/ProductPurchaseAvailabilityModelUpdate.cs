﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product purchase availability.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductPurchaseAvailabilityModelUpdate : ProductPurchaseAvailability, IUrlQueryParameters
    {
    }
}
