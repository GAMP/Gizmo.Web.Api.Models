﻿using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile rate.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BillingProfileRate : BillingProfileRateModelBase, IEntityBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; } 

        #endregion
    }
}