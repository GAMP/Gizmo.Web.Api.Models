using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
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