using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment methods.
    /// </summary>
    [Serializable]
    [DataContract]
    public class PaymentMethodsFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
