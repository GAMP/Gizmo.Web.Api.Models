using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class BillingProfileRateModelUpdate : BillingProfileRateModelBase, IEntityBase
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }
    }
}