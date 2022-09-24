using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product purchase availability.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductPurchaseAvailability : ProductAvailability
    {
    }
}
