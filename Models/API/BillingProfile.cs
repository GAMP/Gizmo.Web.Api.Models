using MessagePack;
using System;
using System.Collections.Generic;
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
    public class BillingProfile : BillingProfileModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The rates of the billing profile.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public IEnumerable<BillingProfileRate> Rates { get; set; }

        #endregion
    }
}