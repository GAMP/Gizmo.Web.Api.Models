using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class BillingProfileModelCreate : BillingProfileModelBase, IUrlQueryParameters
    {
    }
}
