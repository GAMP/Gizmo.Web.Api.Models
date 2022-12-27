﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.BillingProfile.Rate.Model;

using MessagePack;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.BillingProfile
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [MessagePackObject]
    public sealed class BillingProfile : IBillingProfileApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The rates of the billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<BillingProfileRate> Rates { get; set; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [MessagePack.Key(3)]
        [Required]
        public BillingProfileRateModel DefaultRate { get; set; }

        #endregion
    }
}