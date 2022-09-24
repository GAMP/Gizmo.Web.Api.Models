using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BillingProfile : BillingProfileModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The rates of the billing profile.
        /// </summary>
        [Key(101)]
        public IEnumerable<BillingProfileRate> Rates { get; set; }

        #endregion
    }
}