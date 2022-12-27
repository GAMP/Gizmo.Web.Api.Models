using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.PurchaseAvailability
{
    /// <summary>
    /// Product purchase availability.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductPurchaseAvailabilityModelUpdate : ProductPurchaseAvailability, IUrlQueryParameters
    {
    }
}
