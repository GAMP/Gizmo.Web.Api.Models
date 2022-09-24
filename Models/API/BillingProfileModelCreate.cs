using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BillingProfileModelCreate : BillingProfileModelBase, IUrlQueryParameters
    {
    }
}
