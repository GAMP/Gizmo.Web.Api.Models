using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Payment.Method
{
    /// <summary>
    /// Payment method.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class PaymentMethodModelCreate : PaymentMethodModelBase, IUrlQueryParameters
    {
    }
}