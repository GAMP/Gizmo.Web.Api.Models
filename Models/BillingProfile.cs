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
    public class BillingProfile : BillingProfileModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The rates of the billing profile.
        /// </summary>
        [DataMember]
        public IEnumerable<BillingProfileRate> Rates { get; set; }

        #endregion
    }
}