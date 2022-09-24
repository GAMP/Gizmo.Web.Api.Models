using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BillingProfileRateModelCreate : BillingProfileRateModelBase
    {
    }
}